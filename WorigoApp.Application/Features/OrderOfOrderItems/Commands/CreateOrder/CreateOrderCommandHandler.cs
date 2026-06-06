using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : BaseHandler, IRequestHandler<CreateOrderCommandRequest, ResponseDto<CreateOrderCommandResponse>>
    {
        public CreateOrderCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateOrderCommandResponse>> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.CreateOrderItems.Count == 0)
            {
                return new ResponseDto<CreateOrderCommandResponse>()
                    .Fail(new List<string> { "Siparis olusturmak icin en az bir kalem girilmelidir." }, 400);
            }

            var guestStay = await unitOfWork.GetReadRepository<GuestStay>()
                .GetAsync(
                    x => x.IsActive && x.Id == request.GuestStayId && !x.IsDeleted,
                    include: query => query.Include(x => x.Room));

            var hotelPolicies = await unitOfWork.GetReadRepository<HotelServicePolicy>()
                .GetAllAsync(x =>
                    x.IsActive &&
                    !x.IsDeleted &&
                    x.HotelId == guestStay.HotelId &&
                    x.AccommodationConceptType == guestStay.AccommodationConceptType);

            var orderItems = new List<OrderItem>();
            decimal totalPrice = 0;
            decimal taxAmount = 0;
            decimal discountAmount = 0;
            decimal serviceChargeAmount = 0;

            foreach (var item in request.CreateOrderItems)
            {
                if (item.Quantity <= 0)
                {
                    return new ResponseDto<CreateOrderCommandResponse>()
                        .Fail(new List<string> { "Siparis kalem miktari sifirdan buyuk olmalidir." }, 400);
                }

                var pricing = await ResolveCatalogPricingAsync(item, guestStay.HotelId);
                var policy = ResolvePolicy(hotelPolicies, item.ServicesEnumId, item.ServiceItemId);

                if (policy is not null && !policy.IsVisible)
                {
                    return new ResponseDto<CreateOrderCommandResponse>()
                        .Fail(new List<string> { "Secilen hizmet bu konaklama konsepti icin kullanilamaz." }, 400);
                }

                var effectivePaymentOption = ResolvePaymentOption(request.RequestedPaymentOption, policy, pricing.IsChargeable);
                if (effectivePaymentOption is null)
                {
                    return new ResponseDto<CreateOrderCommandResponse>()
                        .Fail(new List<string> { "Secilen hizmet icin izin verilen bir odeme tipi bulunamadi." }, 400);
                }

                var isIncludedInPackage = policy?.IsIncludedInPackage == true;
                var unitPrice = isIncludedInPackage
                    ? 0
                    : policy?.PriceOverride ?? pricing.UnitPrice;
                var lineTotal = unitPrice * item.Quantity;

                totalPrice += lineTotal;

                orderItems.Add(new OrderItem
                {
                    ServicesEnumId = item.ServicesEnumId,
                    ServiceItemId = item.ServiceItemId,
                    Quantity = item.Quantity,
                    Price = unitPrice,
                    UnitPrice = unitPrice,
                    LineTotal = lineTotal,
                    DiscountAmount = 0,
                    TaxAmount = 0,
                    ServiceChargeAmount = 0,
                    CurrencyCode = policy?.CurrencyCode ?? item.CurrencyCode ?? guestStay.CurrencyCode,
                    IsIncludedInPackage = isIncludedInPackage,
                    AppliedHotelServicePolicyId = policy?.Id,
                    PaymentOption = effectivePaymentOption.Value,
                    PriceStatusId = pricing.PriceStatusId,
                    AppointmentDate = item.AppointmentDate,
                    AppointmentLastDate = item.AppointmentLastDate,
                    StatusTypeEnum = StatusTypeEnum.Waiting,
                    Text = item.Text ?? string.Empty
                });
            }

            var orderPaymentOption = orderItems.All(x => x.IsIncludedInPackage)
                ? OrderPaymentOptionEnum.IncludedInPackage
                : request.RequestedPaymentOption;

            var orderPaymentStatus = ResolvePaymentStatus(orderPaymentOption, totalPrice);
            string? paymentRedirectUrl = null;

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var order = await unitOfWork.GetWriteRepository<Order>().AddAsync(new Order
            {
                OrderNumber = $"ORD-{DateTime.UtcNow:yyyyMMddHHmmss}-{Guid.NewGuid():N}"[..30],
                GuestStayId = request.GuestStayId,
                TotalPrice = totalPrice,
                DiscountAmount = discountAmount,
                TaxAmount = taxAmount,
                ServiceChargeAmount = serviceChargeAmount,
                NetAmount = totalPrice + taxAmount + serviceChargeAmount - discountAmount,
                CurrencyCode = guestStay.CurrencyCode,
                PaymentOption = orderPaymentOption,
                PaymentStatus = orderPaymentStatus,
                IsPostedToRoom = orderPaymentOption == OrderPaymentOptionEnum.RoomCharge,
                PostedToRoomAt = orderPaymentOption == OrderPaymentOptionEnum.RoomCharge ? DateTime.UtcNow : null
            });

            await unitOfWork.SaveAsync(cancellationToken);

            foreach (var orderItem in orderItems)
            {
                orderItem.OrderId = order.Id;
                await unitOfWork.GetWriteRepository<OrderItem>().AddAsync(orderItem);
            }

            var chargeStatus = orderPaymentOption switch
            {
                OrderPaymentOptionEnum.IncludedInPackage => ChargeStatusEnum.Paid,
                OrderPaymentOptionEnum.RoomCharge => ChargeStatusEnum.PostedToRoom,
                OrderPaymentOptionEnum.OnlinePayment => ChargeStatusEnum.AwaitingPayment,
                _ => ChargeStatusEnum.Pending
            };

            var serviceRequest = await CreateOperationalServiceRequestAsync(
                request,
                guestStay,
                order,
                orderItems,
                cancellationToken);

            var charge = await unitOfWork.GetWriteRepository<Charge>().AddAsync(new Charge
            {
                GuestStayId = guestStay.Id,
                OrderId = order.Id,
                ServiceRequestId = serviceRequest?.Id,
                Description = $"Order {order.OrderNumber}",
                Amount = order.NetAmount,
                CurrencyCode = order.CurrencyCode,
                IsPostedToRoom = orderPaymentOption == OrderPaymentOptionEnum.RoomCharge,
                PostedToRoomAt = orderPaymentOption == OrderPaymentOptionEnum.RoomCharge ? DateTime.UtcNow : null,
                Status = chargeStatus
            });

            await unitOfWork.SaveAsync(cancellationToken);

            if (orderPaymentOption == OrderPaymentOptionEnum.OnlinePayment && totalPrice > 0)
            {
                paymentRedirectUrl = $"/payments/checkout/{charge.Id}";

                await unitOfWork.GetWriteRepository<PaymentTransaction>().AddAsync(new PaymentTransaction
                {
                    ChargeId = charge.Id,
                    Amount = charge.Amount,
                    CurrencyCode = charge.CurrencyCode,
                    PaymentProvider = PaymentProviderEnum.Manual,
                    PaymentMethod = "OnlineLink",
                    PaymentStatus = OrderPaymentStatusEnum.AwaitingOnlinePayment,
                    RedirectUrl = paymentRedirectUrl
                });
            }

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateOrderCommandResponse>().Success(new CreateOrderCommandResponse
            {
                Id = order.Id,
                GuestStayId = order.GuestStayId,
                TotalPrice = order.NetAmount,
                CurrencyCode = order.CurrencyCode,
                PaymentOption = order.PaymentOption.ToString(),
                PaymentStatus = order.PaymentStatus.ToString(),
                IsPostedToRoom = order.IsPostedToRoom,
                ServiceRequestId = serviceRequest?.Id,
                PaymentRedirectUrl = paymentRedirectUrl,
                OrderItemCount = orderItems.Count,
                CreatedAt = order.CreatedDate
            });
        }

        private static HotelServicePolicy? ResolvePolicy(IList<HotelServicePolicy> policies, ServicesEnum serviceType, int serviceItemId)
        {
            return policies
                .OrderByDescending(x => x.ServiceDefinitionId.HasValue)
                .ThenByDescending(x => x.ServiceItemId.HasValue)
                .FirstOrDefault(x =>
                    (x.ServiceDefinitionId == serviceItemId) ||
                    (x.ServiceDefinitionId is null &&
                     x.ServiceType == serviceType &&
                     (x.ServiceItemId == serviceItemId || x.ServiceItemId is null)));
        }

        private static OrderPaymentOptionEnum? ResolvePaymentOption(
            OrderPaymentOptionEnum requestedPaymentOption,
            HotelServicePolicy? policy,
            bool isChargeable)
        {
            if (policy?.IsIncludedInPackage == true || !isChargeable)
            {
                return OrderPaymentOptionEnum.IncludedInPackage;
            }

            if (policy is null)
            {
                return requestedPaymentOption;
            }

            return requestedPaymentOption switch
            {
                OrderPaymentOptionEnum.RoomCharge when policy.AllowRoomCharge => OrderPaymentOptionEnum.RoomCharge,
                OrderPaymentOptionEnum.OnlinePayment when policy.AllowOnlinePayment => OrderPaymentOptionEnum.OnlinePayment,
                OrderPaymentOptionEnum.OnSitePayment when policy.AllowOnSitePayment => OrderPaymentOptionEnum.OnSitePayment,
                _ when policy.AllowRoomCharge => OrderPaymentOptionEnum.RoomCharge,
                _ when policy.AllowOnlinePayment => OrderPaymentOptionEnum.OnlinePayment,
                _ when policy.AllowOnSitePayment => OrderPaymentOptionEnum.OnSitePayment,
                _ => null
            };
        }

        private static OrderPaymentStatusEnum ResolvePaymentStatus(OrderPaymentOptionEnum paymentOption, decimal totalPrice)
        {
            if (totalPrice <= 0 || paymentOption == OrderPaymentOptionEnum.IncludedInPackage)
            {
                return OrderPaymentStatusEnum.Paid;
            }

            return paymentOption switch
            {
                OrderPaymentOptionEnum.RoomCharge => OrderPaymentStatusEnum.Pending,
                OrderPaymentOptionEnum.OnlinePayment => OrderPaymentStatusEnum.AwaitingOnlinePayment,
                OrderPaymentOptionEnum.OnSitePayment => OrderPaymentStatusEnum.Pending,
                _ => OrderPaymentStatusEnum.Pending
            };
        }

        private async Task<(decimal UnitPrice, int PriceStatusId, bool IsChargeable)> ResolveCatalogPricingAsync(
            Dto.CreateOrderItems item,
            int hotelId)
        {
            decimal calculatedUnitPrice = item.Price;
            var priceStatusId = item.PriceStatusId;
            var isChargeable = item.Price > 0;

            if (item.ServicesEnumId == ServicesEnum.Menu)
            {
                var foodData = await unitOfWork.GetReadRepository<Food>()
                    .GetAsync(x => x.Id == item.ServiceItemId && x.IsAvailable && !x.IsDeleted);

                calculatedUnitPrice = foodData.DiscountPrice ?? foodData.Price;
                priceStatusId = foodData.PriceStatusId;
                isChargeable = calculatedUnitPrice > 0;

                return (calculatedUnitPrice, priceStatusId, isChargeable);
            }

            var definition = await unitOfWork.GetReadRepository<ServiceDefinition>()
                .GetAsync(x =>
                    x.Id == item.ServiceItemId &&
                    x.HotelId == hotelId &&
                    x.ServiceType == item.ServicesEnumId &&
                    x.IsActive &&
                    !x.IsDeleted);

            calculatedUnitPrice = definition.Price;
            isChargeable = definition.IsChargeable;

            return (calculatedUnitPrice, priceStatusId, isChargeable);
        }

        private async Task<ServiceRequest?> CreateOperationalServiceRequestAsync(
            CreateOrderCommandRequest request,
            GuestStay guestStay,
            Order order,
            IList<OrderItem> orderItems,
            CancellationToken cancellationToken)
        {
            var primaryServiceType = request.CreateOrderItems
                .Select(x => x.ServicesEnumId)
                .FirstOrDefault();

            if (primaryServiceType == default)
            {
                return null;
            }

            var primaryServiceItemId = request.CreateOrderItems
                .Where(x => x.ServicesEnumId == primaryServiceType)
                .Select(x => x.ServiceItemId)
                .FirstOrDefault();

            var serviceDefinition = (await unitOfWork.GetReadRepository<ServiceDefinition>()
                .GetAllAsync(x =>
                    x.HotelId == guestStay.HotelId &&
                    x.ServiceType == primaryServiceType &&
                    (primaryServiceType == ServicesEnum.Menu || x.Id == primaryServiceItemId) &&
                    x.IsActive &&
                    !x.IsDeleted,
                    orderBy: x => x.OrderBy(y => y.DisplayOrder)))
                .FirstOrDefault();

            var assignments = await unitOfWork.GetReadRepository<ServiceRoleAssignments>().GetAllAsync(
                x => x.HotelId == guestStay.HotelId && x.ServicesEnumId == primaryServiceType && x.IsActive && !x.IsDeleted,
                orderBy: x => x.OrderBy(y => y.Priority));

            var assignment = assignments.FirstOrDefault();
            var assignedEmployee = await FindAvailableEmployeeAsync(guestStay.HotelId, assignments);
            var now = DateTime.UtcNow;

            var serviceRequest = await unitOfWork.GetWriteRepository<ServiceRequest>().AddAsync(new ServiceRequest
            {
                HotelId = guestStay.HotelId,
                GuestStayId = guestStay.Id,
                RoomId = guestStay.RoomId,
                ServiceType = primaryServiceType,
                ServiceCatalogItemId = serviceDefinition?.Id,
                ServiceDefinitionId = serviceDefinition?.Id,
                Title = ResolveOrderServiceRequestTitle(primaryServiceType),
                Description = BuildOrderDescription(order.OrderNumber, request.CreateOrderItems),
                Priority = ServiceRequestPriorityEnum.Normal,
                RequestSource = ServiceRequestSourceEnum.Mobile,
                LanguageCode = guestStay.GuestLanguageCode,
                RequestedAt = now,
                DepartmentId = assignment?.DepartmentId ?? serviceDefinition?.DepartmentId,
                DueAt = assignment?.SlaMinutes is int sla ? now.AddMinutes(sla) : null,
                AssignedEmployeeId = assignedEmployee?.Id,
                AssignedAt = assignedEmployee is not null ? now : null,
                Status = assignedEmployee is not null ? ServiceRequestStatusEnum.Assigned : ServiceRequestStatusEnum.Open
            });

            await unitOfWork.SaveAsync(cancellationToken);

            order.ServiceRequestId = serviceRequest.Id;
            await unitOfWork.GetWriteRepository<Order>().UpdateAsync(order);

            for (var index = 0; index < request.CreateOrderItems.Count; index++)
            {
                var requestItem = request.CreateOrderItems[index];
                var orderItem = orderItems[index];

                await unitOfWork.GetWriteRepository<ServiceRequestItem>().AddAsync(new ServiceRequestItem
                {
                    ServiceRequestId = serviceRequest.Id,
                    ServiceDefinitionId = serviceDefinition?.Id,
                    ItemName = string.IsNullOrWhiteSpace(requestItem.ItemName)
                        ? $"{requestItem.ServicesEnumId} #{requestItem.ServiceItemId}"
                        : requestItem.ItemName,
                    Quantity = orderItem.Quantity,
                    Note = requestItem.Text
                });
            }

            await unitOfWork.GetWriteRepository<ServiceRequestHistory>().AddAsync(new ServiceRequestHistory
            {
                ServiceRequestId = serviceRequest.Id,
                NewStatus = serviceRequest.Status,
                ChangedAt = now,
                Note = assignedEmployee is not null
                    ? $"Siparis operasyon talebi olusturuldu ve personele atandi. OrderId: {order.Id}, PersonelId: {assignedEmployee.Id}"
                    : $"Siparis operasyon talebi olusturuldu. OrderId: {order.Id}"
            });

            if (assignedEmployee is not null)
            {
                assignedEmployee.LastAssignedAt = now;
                await unitOfWork.GetWriteRepository<Employee>().UpdateAsync(assignedEmployee);
            }

            await unitOfWork.SaveAsync(cancellationToken);
            return serviceRequest;
        }

        private async Task<Employee?> FindAvailableEmployeeAsync(int hotelId, IList<ServiceRoleAssignments> assignments)
        {
            foreach (var assignment in assignments)
            {
                var employees = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(
                    x => x.HotelId == hotelId &&
                         x.EmployeeTypeId == assignment.EmployeeTypeRoleId &&
                         x.IsActive &&
                         !x.IsDeleted &&
                         x.Status &&
                         x.IsAvailableForTask,
                    orderBy: x => x.OrderBy(y => y.LastAssignedAt ?? DateTime.MinValue));

                var availableEmployee = employees.FirstOrDefault();
                if (availableEmployee is not null)
                {
                    return availableEmployee;
                }
            }

            return null;
        }

        private static string ResolveOrderServiceRequestTitle(ServicesEnum serviceType)
        {
            return serviceType switch
            {
                ServicesEnum.Menu => "Yemek Siparisi",
                ServicesEnum.Minibar => "Minibar Talebi",
                ServicesEnum.SpaMessage => "Spa Rezervasyonu",
                ServicesEnum.DryCleaner => "Camasirhane Talebi",
                _ => $"{serviceType} Talebi"
            };
        }

        private static string BuildOrderDescription(string orderNumber, IList<Dto.CreateOrderItems> items)
        {
            var itemText = string.Join(", ", items.Select(x =>
                $"{(string.IsNullOrWhiteSpace(x.ItemName) ? $"{x.ServicesEnumId} #{x.ServiceItemId}" : x.ItemName)} x{x.Quantity}"));

            return $"{orderNumber}: {itemText}";
        }
    }
}
