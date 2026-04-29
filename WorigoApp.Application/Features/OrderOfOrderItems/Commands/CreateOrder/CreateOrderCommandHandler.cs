using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Helpers.DesignPatterns.StrategyAndFactory.Implementasyons;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;
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

            var serviceStrategyFactory = new ServiceStrategyFactory(unitOfWork);
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

                var pricing = await ResolveCatalogPricingAsync(item, serviceStrategyFactory);
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

            var charge = await unitOfWork.GetWriteRepository<Charge>().AddAsync(new Charge
            {
                GuestStayId = guestStay.Id,
                OrderId = order.Id,
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
                PaymentRedirectUrl = paymentRedirectUrl,
                OrderItemCount = orderItems.Count,
                CreatedAt = order.CreatedDate
            });
        }

        private static HotelServicePolicy? ResolvePolicy(IList<HotelServicePolicy> policies, ServicesEnum serviceType, int serviceItemId)
        {
            return policies
                .OrderByDescending(x => x.ServiceItemId.HasValue)
                .FirstOrDefault(x => x.ServiceType == serviceType && (x.ServiceItemId == serviceItemId || x.ServiceItemId is null));
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

        private static async Task<(decimal UnitPrice, int PriceStatusId, bool IsChargeable)> ResolveCatalogPricingAsync(
            Dto.CreateOrderItems item,
            ServiceStrategyFactory serviceStrategyFactory)
        {
            decimal calculatedUnitPrice = item.Price;
            var priceStatusId = item.PriceStatusId;
            var isChargeable = item.Price > 0;

            switch (item.ServicesEnumId)
            {
                case ServicesEnum.Menu:
                    var foodServiceStrategy = serviceStrategyFactory.GetServiceStrategy<Food>(item.ServicesEnumId);
                    var foodData = await foodServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = foodData.DiscountPrice ?? foodData.Price;
                    priceStatusId = foodData.PriceStatusId;
                    isChargeable = calculatedUnitPrice > 0;
                    break;

                case ServicesEnum.SpaMessage:
                    var spaServiceStrategy = serviceStrategyFactory.GetServiceStrategy<SpaMassage>(item.ServicesEnumId);
                    var spaData = await spaServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = spaData.Price;
                    priceStatusId = spaData.PriceStatusId;
                    isChargeable = spaData.IsChargeable;
                    break;

                case ServicesEnum.DryCleaner:
                    var dryCleanerServiceStrategy = serviceStrategyFactory.GetServiceStrategy<DryCleaner>(item.ServicesEnumId);
                    var dryCleanerData = await dryCleanerServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = dryCleanerData.Price ?? item.Price;
                    priceStatusId = dryCleanerData.PriceStatusId;
                    isChargeable = dryCleanerData.IsChargeable;
                    break;

                case ServicesEnum.BellBoy:
                    var bellBoyServiceStrategy = serviceStrategyFactory.GetServiceStrategy<BellBoy>(item.ServicesEnumId);
                    await bellBoyServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = item.Price;
                    isChargeable = item.Price > 0;
                    break;

                case ServicesEnum.TechnicalNeed:
                    var technicalServiceStrategy = serviceStrategyFactory.GetServiceStrategy<TechnicalNeed>(item.ServicesEnumId);
                    await technicalServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = item.Price;
                    isChargeable = item.Price > 0;
                    break;

                case ServicesEnum.HouseKeeping:
                    var houseKeepingServiceStrategy = serviceStrategyFactory.GetServiceStrategy<HouseKeeping>(item.ServicesEnumId);
                    await houseKeepingServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = item.Price;
                    isChargeable = item.Price > 0;
                    break;

                case ServicesEnum.Minibar:
                    var minibarServiceStrategy = serviceStrategyFactory.GetServiceStrategy<MinibarService>(item.ServicesEnumId);
                    var minibarData = await minibarServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = minibarData.Price;
                    priceStatusId = minibarData.PriceStatusId;
                    isChargeable = minibarData.IsChargeable;
                    break;

                case ServicesEnum.WakeUpCall:
                    var wakeUpCallServiceStrategy = serviceStrategyFactory.GetServiceStrategy<WakeUpCallService>(item.ServicesEnumId);
                    var wakeUpCallData = await wakeUpCallServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = wakeUpCallData.Price;
                    priceStatusId = wakeUpCallData.PriceStatusId;
                    isChargeable = wakeUpCallData.IsChargeable;
                    break;

                case ServicesEnum.ValetParking:
                    var valetParkingServiceStrategy = serviceStrategyFactory.GetServiceStrategy<ValetParkingService>(item.ServicesEnumId);
                    var valetParkingData = await valetParkingServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = valetParkingData.Price;
                    priceStatusId = valetParkingData.PriceStatusId;
                    isChargeable = valetParkingData.IsChargeable;
                    break;

                case ServicesEnum.StayExtension:
                    var stayExtensionServiceStrategy = serviceStrategyFactory.GetServiceStrategy<StayExtensionService>(item.ServicesEnumId);
                    var stayExtensionData = await stayExtensionServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = stayExtensionData.Price;
                    priceStatusId = stayExtensionData.PriceStatusId;
                    isChargeable = stayExtensionData.IsChargeable;
                    break;

                case ServicesEnum.AmenityRequest:
                    var amenityRequestServiceStrategy = serviceStrategyFactory.GetServiceStrategy<AmenityRequestService>(item.ServicesEnumId);
                    var amenityRequestData = await amenityRequestServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = amenityRequestData.Price;
                    priceStatusId = amenityRequestData.PriceStatusId;
                    isChargeable = amenityRequestData.IsChargeable;
                    break;

                case ServicesEnum.MedicalAssistance:
                    var medicalAssistanceServiceStrategy = serviceStrategyFactory.GetServiceStrategy<MedicalAssistanceService>(item.ServicesEnumId);
                    var medicalAssistanceData = await medicalAssistanceServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = medicalAssistanceData.Price;
                    priceStatusId = medicalAssistanceData.PriceStatusId;
                    isChargeable = medicalAssistanceData.IsChargeable;
                    break;

                case ServicesEnum.TravelOrTransportation:
                    var travelServiceStrategy = serviceStrategyFactory.GetServiceStrategy<TravelOrTransportation>(item.ServicesEnumId);
                    var travelData = await travelServiceStrategy.GetServiceItemAsync(item.ServiceItemId);
                    calculatedUnitPrice = travelData.Price;
                    priceStatusId = travelData.PriceStatusId;
                    isChargeable = travelData.IsChargeable;
                    break;

                default:
                    throw new NotImplementedException("Unknown service type.");
            }

            return (calculatedUnitPrice, priceStatusId, isChargeable);
        }
    }
}
