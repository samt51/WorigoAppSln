using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Commands.CancelRestaurantReservation
{
/// <summary>
/// CancelRestaurantReservationCommandHandler sınıfını temsil eder.
/// </summary>
public class CancelRestaurantReservationCommandHandler : IRequestHandler<CancelRestaurantReservationCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// CancelRestaurantReservationCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CancelRestaurantReservationCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<bool>> Handle(CancelRestaurantReservationCommandRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<bool>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var reservation = await _unitOfWork.GetReadRepository<RestaurantReservation>().FindAsync(
                x => x.Id == request.Id && x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                enableTracking: true);

            if (reservation is null) return new ResponseDto<bool>().Fail("Rezervasyon bulunamadı.", 404);

            reservation.Status = "Cancelled";
            reservation.CancelledAt = DateTime.UtcNow;
            reservation.ModifyDate = DateTime.Now;

            await _unitOfWork.GetWriteRepository<RestaurantReservation>().UpdateAsync(reservation);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }
    }
}
