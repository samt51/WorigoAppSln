using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Orders.Queries.GetFoodOrders
{
/// <summary>
/// GetFoodOrdersQueryHandler sınıfını temsil eder.
/// </summary>
public class GetFoodOrdersQueryHandler : IRequestHandler<GetFoodOrdersQueryRequest, ResponseDto<IList<Order>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetFoodOrdersQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetFoodOrdersQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<Order>>> Handle(GetFoodOrdersQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<Order>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var orders = await _unitOfWork.GetReadRepository<Order>().GetAllAsync(
                x => x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                include: q => q.Include(x => x.OrderItems),
                enableTracking: false);

            return new ResponseDto<IList<Order>>().Success(orders);
        }
    }
}
