using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetMyRestaurantReservations
{
    public class GetMyRestaurantReservationsQueryHandler : IRequestHandler<GetMyRestaurantReservationsQueryRequest, ResponseDto<IList<RestaurantReservation>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetMyRestaurantReservationsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<IList<RestaurantReservation>>> Handle(GetMyRestaurantReservationsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<RestaurantReservation>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var reservations = await _unitOfWork.GetReadRepository<RestaurantReservation>().GetAllAsync(
                x => x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                include: q => q.Include(x => x.Restaurant),
                orderBy: q => q.OrderByDescending(x => x.ReservationDate),
                enableTracking: false);

            return new ResponseDto<IList<RestaurantReservation>>().Success(reservations);
        }
    }
}
