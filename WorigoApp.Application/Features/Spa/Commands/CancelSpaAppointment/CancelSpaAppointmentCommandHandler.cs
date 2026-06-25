using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Commands.CancelSpaAppointment
{
/// <summary>
/// CancelSpaAppointmentCommandHandler sınıfını temsil eder.
/// </summary>
public class CancelSpaAppointmentCommandHandler : IRequestHandler<CancelSpaAppointmentCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// CancelSpaAppointmentCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CancelSpaAppointmentCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<bool>> Handle(CancelSpaAppointmentCommandRequest request, CancellationToken cancellationToken)
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

            var appointment = await _unitOfWork.GetReadRepository<SpaAppointment>().FindAsync(
                x => x.Id == request.Id && x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                enableTracking: true);

            if (appointment is null) return new ResponseDto<bool>().Fail("Randevu bulunamadı.", 404);

            appointment.Status = "Cancelled";
            appointment.ModifyDate = DateTime.Now;

            await _unitOfWork.GetWriteRepository<SpaAppointment>().UpdateAsync(appointment);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }
    }
}
