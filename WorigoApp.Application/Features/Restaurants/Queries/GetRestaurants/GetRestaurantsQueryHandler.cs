using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurants
{
/// <summary>
/// GetRestaurantsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetRestaurantsQueryHandler : IRequestHandler<GetRestaurantsQueryRequest, ResponseDto<IList<Restaurant>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetRestaurantsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetRestaurantsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<Restaurant>>> Handle(GetRestaurantsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<Restaurant>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var restaurants = await _unitOfWork.GetReadRepository<Restaurant>().GetAllAsync(
                x => x.HotelId == session.GuestStay.HotelId && x.IsActive && !x.IsDeleted,
                orderBy: q => q.OrderBy(x => x.DisplayOrder),
                enableTracking: false);

            return new ResponseDto<IList<Restaurant>>().Success(restaurants);
        }
    }
}
