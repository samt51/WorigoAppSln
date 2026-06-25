using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergePlace
{
/// <summary>
/// GetConciergePlaceQueryHandler sınıfını temsil eder.
/// </summary>
public class GetConciergePlaceQueryHandler : IRequestHandler<GetConciergePlaceQueryRequest, ResponseDto<ConciergePlace>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetConciergePlaceQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetConciergePlaceQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<ConciergePlace>> Handle(GetConciergePlaceQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<ConciergePlace>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var place = await _unitOfWork.GetReadRepository<ConciergePlace>().FindAsync(
                x => x.Id == request.Id && x.HotelId == session.GuestStay.HotelId && !x.IsDeleted,
                enableTracking: false);

            if (place is null) return new ResponseDto<ConciergePlace>().Fail("Yer bulunamadı.", 404);

            return new ResponseDto<ConciergePlace>().Success(place);
        }
    }
}
