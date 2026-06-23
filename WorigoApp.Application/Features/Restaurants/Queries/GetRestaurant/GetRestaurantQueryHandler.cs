using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurant
{
    public class GetRestaurantQueryHandler : IRequestHandler<GetRestaurantQueryRequest, ResponseDto<Restaurant>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetRestaurantQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<Restaurant>> Handle(GetRestaurantQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<Restaurant>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var restaurant = await _unitOfWork.GetReadRepository<Restaurant>().FindAsync(
                x => x.Id == request.RestaurantId && x.HotelId == session.GuestStay.HotelId && !x.IsDeleted,
                enableTracking: false);

            if (restaurant is null) return new ResponseDto<Restaurant>().Fail("Restoran bulunamadı.", 404);

            return new ResponseDto<Restaurant>().Success(restaurant);
        }
    }
}
