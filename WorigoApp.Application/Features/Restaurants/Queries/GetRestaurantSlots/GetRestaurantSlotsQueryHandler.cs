using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantSlots
{
/// <summary>
/// GetRestaurantSlotsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetRestaurantSlotsQueryHandler : IRequestHandler<GetRestaurantSlotsQueryRequest, ResponseDto<IList<string>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetRestaurantSlotsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetRestaurantSlotsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<string>>> Handle(GetRestaurantSlotsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<string>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var restaurant = await _unitOfWork.GetReadRepository<Restaurant>().FindAsync(
                x => x.Id == request.RestaurantId && x.HotelId == session.GuestStay.HotelId && !x.IsDeleted,
                enableTracking: false);

            if (restaurant is null) return new ResponseDto<IList<string>>().Fail("Restoran bulunamadı.", 404);

            if (!DateTime.TryParse(request.Date, out var parsedDate))
            {
                return new ResponseDto<IList<string>>().Fail("Geçersiz tarih formatı.", 400);
            }

            var slots = new List<string>();
            var open = restaurant.OpeningTime;
            var close = restaurant.ClosingTime;

            if (close < open) close = close.Add(TimeSpan.FromDays(1));

            var current = open;
            while (current < close)
            {
                slots.Add(current.ToString(@"hh\:mm"));
                current = current.Add(TimeSpan.FromHours(1));
            }

            var availableSlots = new List<string>();
            foreach (var slot in slots)
            {
                var reservations = await _unitOfWork.GetReadRepository<RestaurantReservation>().GetAllAsync(
                    x => x.RestaurantId == request.RestaurantId &&
                          x.ReservationDate.Date == parsedDate.Date &&
                          x.TimeSlot == slot &&
                          x.Status != "Cancelled" &&
                          x.Status != "Rejected" &&
                          !x.IsDeleted);

                var reservedCount = reservations.Sum(x => x.GuestCount);

                if (reservedCount < restaurant.Capacity)
                {
                    availableSlots.Add(slot);
                }
            }

            return new ResponseDto<IList<string>>().Success(availableSlots);
        }
    }
}
