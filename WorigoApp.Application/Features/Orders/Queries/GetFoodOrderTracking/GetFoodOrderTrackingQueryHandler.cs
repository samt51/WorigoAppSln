using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Orders.Dtos;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrderTracking
{
/// <summary>
/// GetFoodOrderTrackingQueryHandler sınıfını temsil eder.
/// </summary>
public class GetFoodOrderTrackingQueryHandler : IRequestHandler<GetFoodOrderTrackingQueryRequest, ResponseDto<OrderTrackingDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetFoodOrderTrackingQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetFoodOrderTrackingQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<OrderTrackingDto>> Handle(GetFoodOrderTrackingQueryRequest request, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;
            var today = DateTime.Today;

            var session = await _unitOfWork.GetReadRepository<GuestSession>().FindAsync(
                x => x.SessionToken == request.SessionToken &&
                     x.IsActiveSession &&
                     x.IsActive &&
                     !x.IsDeleted &&
                     x.ExpiresAt > now &&
                     x.GuestStay.IsActive &&
                     !x.GuestStay.IsDeleted &&
                     x.GuestStay.IsMobileAccessEnabled &&
                     x.GuestStay.CheckInDate.Date <= today &&
                     x.GuestStay.CheckOutDate.Date >= today &&
                     x.GuestStay.ActualCheckOutAt == null,
                include: q => q.Include(x => x.GuestStay));

            if (session is null) return new ResponseDto<OrderTrackingDto>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var order = await _unitOfWork.GetReadRepository<Order>().FindAsync(
                x => x.Id == request.OrderId && x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                enableTracking: false);

            if (order is null) return new ResponseDto<OrderTrackingDto>().Fail("Sipariş bulunamadı.", 404);

            var tracking = new OrderTrackingDto
            {
                OrderId = order.Id,
                OrderStatus = order.OrderStatus.ToString(),
                ReceivedAt = order.CreatedDate,
                PreparationStartedAt = order.PreparationStartedAt,
                ReadyAt = order.ReadyAt,
                DeliveryStartedAt = order.DeliveryStartedAt,
                DeliveredAt = order.DeliveredAt
            };

            return new ResponseDto<OrderTrackingDto>().Success(tracking);
        }
    }
}
