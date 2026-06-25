using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Commands.CreateSpaAppointment
{
/// <summary>
/// CreateSpaAppointmentCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateSpaAppointmentCommandHandler : IRequestHandler<CreateSpaAppointmentCommandRequest, ResponseDto<SpaAppointment>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// CreateSpaAppointmentCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateSpaAppointmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<SpaAppointment>> Handle(CreateSpaAppointmentCommandRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<SpaAppointment>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var existingAppt = await _unitOfWork.GetReadRepository<SpaAppointment>().FindAsync(
                x => x.HotelId == session.GuestStay.HotelId &&
                     x.AppointmentDate.Date == request.AppointmentDate.Date &&
                     x.TimeSlot == request.TimeSlot &&
                     x.Status != "Cancelled" &&
                     !x.IsDeleted);

            if (existingAppt is not null)
            {
                return new ResponseDto<SpaAppointment>().Fail("Seçilen randevu saati dolu.", 400);
            }

            var appt = new SpaAppointment
            {
                HotelId = session.GuestStay.HotelId,
                GuestStayId = session.GuestStayId,
                ServiceName = request.ServiceName,
                TherapistName = request.TherapistName ?? "Fark etmez",
                AppointmentDate = request.AppointmentDate.Date,
                TimeSlot = request.TimeSlot,
                Price = request.Price,
                CurrencyCode = request.CurrencyCode ?? "TRY",
                Status = "Confirmed",
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            await _unitOfWork.GetWriteRepository<SpaAppointment>().AddAsync(appt);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<SpaAppointment>().Success(appt);
        }
    }
}
