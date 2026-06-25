using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrderDetails
{
/// <summary>
/// GetFoodOrderDetailsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetFoodOrderDetailsQueryHandler : IRequestHandler<GetFoodOrderDetailsQueryRequest, ResponseDto<Order>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetFoodOrderDetailsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetFoodOrderDetailsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<Order>> Handle(GetFoodOrderDetailsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<Order>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var order = await _unitOfWork.GetReadRepository<Order>().FindAsync(
                x => x.Id == request.OrderId && x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                include: q => q.Include(x => x.OrderItems),
                enableTracking: false);

            if (order is null) return new ResponseDto<Order>().Fail("Sipariş bulunamadı.", 404);

            return new ResponseDto<Order>().Success(order);
        }
    }
}
