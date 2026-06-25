using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaSlots
{
/// <summary>
/// GetSpaSlotsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetSpaSlotsQueryHandler : IRequestHandler<GetSpaSlotsQueryRequest, ResponseDto<IList<string>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetSpaSlotsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetSpaSlotsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<string>>> Handle(GetSpaSlotsQueryRequest request, CancellationToken cancellationToken)
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

            if (!DateTime.TryParse(request.Date, out var parsedDate))
            {
                return new ResponseDto<IList<string>>().Fail("Geçersiz tarih formatı.", 400);
            }

            var slots = new List<string>();
            var current = TimeSpan.FromHours(9);
            var end = TimeSpan.FromHours(21);
            while (current < end)
            {
                slots.Add(current.ToString(@"hh\:mm"));
                current = current.Add(TimeSpan.FromHours(1));
            }

            var bookedAppointments = await _unitOfWork.GetReadRepository<SpaAppointment>().GetAllAsync(
                x => x.HotelId == session.GuestStay.HotelId &&
                     x.AppointmentDate.Date == parsedDate.Date &&
                     x.Status != "Cancelled" &&
                     !x.IsDeleted);

            var bookedSlots = bookedAppointments.Select(x => x.TimeSlot).ToList();

            var availableSlots = slots.Except(bookedSlots).ToList();
            return new ResponseDto<IList<string>>().Success(availableSlots);
        }
    }
}
