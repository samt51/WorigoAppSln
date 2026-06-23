using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

using WorigoApp.Application.Interfaces.AutoMapper;

namespace WorigoApp.Application.Features.Orders.Commands.UpdateFoodOrderStatus
{
    public class UpdateFoodOrderStatusCommandHandler : BaseHandler, IRequestHandler<UpdateFoodOrderStatusCommandRequest, ResponseDto<UpdateFoodOrderStatusResponse>>
    {
        public UpdateFoodOrderStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateFoodOrderStatusResponse>> Handle(UpdateFoodOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var staff = await unitOfWork.GetReadRepository<Users>().FindAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(x => x.Employee),
                enableTracking: false);

            if (staff is null || staff.Employee is null)
            {
                return new ResponseDto<UpdateFoodOrderStatusResponse>().Fail("Personel kaydı bulunamadı.", 401);
            }

            var order = await unitOfWork.GetReadRepository<Order>().FindAsync(
                x => x.Id == request.OrderId && x.GuestStay.HotelId == staff.Employee.HotelId && !x.IsDeleted,
                include: q => q.Include(x => x.GuestStay),
                enableTracking: true);

            if (order is null) return new ResponseDto<UpdateFoodOrderStatusResponse>().Fail("Sipariş bulunamadı.", 404);

            if (!Enum.TryParse<OrderStatusEnum>(request.Status, true, out var newStatus))
            {
                return new ResponseDto<UpdateFoodOrderStatusResponse>().Fail("Geçersiz sipariş durumu.", 400);
            }

            order.OrderStatus = newStatus;
            order.ModifyDate = DateTime.Now;

            var now = DateTime.UtcNow;
            if (newStatus == OrderStatusEnum.Preparing)
            {
                order.PreparationStartedAt = now;
            }
            else if (newStatus == OrderStatusEnum.Ready)
            {
                order.ReadyAt = now;
            }
            else if (newStatus == OrderStatusEnum.OnTheWay)
            {
                order.DeliveryStartedAt = now;
            }
            else if (newStatus == OrderStatusEnum.Delivered)
            {
                order.DeliveredAt = now;
                order.PaymentStatus = OrderPaymentStatusEnum.Paid;
            }

            await unitOfWork.GetWriteRepository<Order>().UpdateAsync(order);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpdateFoodOrderStatusResponse>().Success(new UpdateFoodOrderStatusResponse
            {
                OrderId = order.Id,
                GuestStayId = order.GuestStayId,
                OrderStatus = order.OrderStatus,
                UpdatedAt = now
            });
        }
    }
}
