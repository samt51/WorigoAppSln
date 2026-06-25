using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaAppointments
{
/// <summary>
/// GetSpaAppointmentsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetSpaAppointmentsQueryHandler : IRequestHandler<GetSpaAppointmentsQueryRequest, ResponseDto<IList<SpaAppointment>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetSpaAppointmentsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetSpaAppointmentsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<SpaAppointment>>> Handle(GetSpaAppointmentsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<SpaAppointment>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var appointments = await _unitOfWork.GetReadRepository<SpaAppointment>().GetAllAsync(
                x => x.GuestStayId == session.GuestStayId && !x.IsDeleted,
                orderBy: q => q.OrderByDescending(x => x.AppointmentDate),
                enableTracking: false);

            return new ResponseDto<IList<SpaAppointment>>().Success(appointments);
        }
    }
}
