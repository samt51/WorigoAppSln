using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Spa.Queries.GetSpaServices
{
/// <summary>
/// GetSpaServicesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetSpaServicesQueryHandler : IRequestHandler<GetSpaServicesQueryRequest, ResponseDto<IList<SpaService>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetSpaServicesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetSpaServicesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<SpaService>>> Handle(GetSpaServicesQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<SpaService>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var services = await _unitOfWork.GetReadRepository<SpaService>().GetAllAsync(
                x => x.HotelId == session.GuestStay.HotelId && x.IsActive && !x.IsDeleted,
                enableTracking: false);

            return new ResponseDto<IList<SpaService>>().Success(services);
        }
    }
}
