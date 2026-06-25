using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Commands.CreateRestaurantReservation
{
/// <summary>
/// CreateRestaurantReservationCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateRestaurantReservationCommandHandler : IRequestHandler<CreateRestaurantReservationCommandRequest, ResponseDto<RestaurantReservation>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// CreateRestaurantReservationCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateRestaurantReservationCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<RestaurantReservation>> Handle(CreateRestaurantReservationCommandRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<RestaurantReservation>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var restaurant = await _unitOfWork.GetReadRepository<Restaurant>().FindAsync(
                x => x.Id == request.RestaurantId && x.HotelId == session.GuestStay.HotelId && !x.IsDeleted,
                enableTracking: false);

            if (restaurant is null) return new ResponseDto<RestaurantReservation>().Fail("Restoran bulunamadı.", 404);

            var reservations = await _unitOfWork.GetReadRepository<RestaurantReservation>().GetAllAsync(
                x => x.RestaurantId == request.RestaurantId &&
                     x.ReservationDate.Date == request.ReservationDate.Date &&
                     x.TimeSlot == request.TimeSlot &&
                     x.Status != "Cancelled" &&
                     x.Status != "Rejected" &&
                     !x.IsDeleted);

            var reservedCount = reservations.Sum(x => x.GuestCount);

            if (reservedCount + request.GuestCount > restaurant.Capacity)
            {
                return new ResponseDto<RestaurantReservation>().Fail("Seçilen saat diliminde yeterli kapasite bulunmamaktadır.", 400);
            }

            var reservation = new RestaurantReservation
            {
                HotelId = session.GuestStay.HotelId,
                GuestStayId = session.GuestStayId,
                CustomerId = session.CustomerId ?? 0,
                RestaurantId = request.RestaurantId,
                ReservationDate = request.ReservationDate.Date,
                TimeSlot = request.TimeSlot,
                GuestCount = request.GuestCount,
                Note = request.Note,
                Status = "Pending",
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            await _unitOfWork.GetWriteRepository<RestaurantReservation>().AddAsync(reservation);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<RestaurantReservation>().Success(reservation);
        }
    }
}
