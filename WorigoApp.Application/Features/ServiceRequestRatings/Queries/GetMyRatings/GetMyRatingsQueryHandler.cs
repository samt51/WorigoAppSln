using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetMyRatings
{
/// <summary>
/// GetMyRatingsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetMyRatingsQueryHandler : IRequestHandler<GetMyRatingsQueryRequest, ResponseDto<IList<ServiceRequestRating>>>
    {
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// GetMyRatingsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetMyRatingsQueryHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<ServiceRequestRating>>> Handle(GetMyRatingsQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<IList<ServiceRequestRating>>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            var ratings = await _unitOfWork.GetReadRepository<ServiceRequestRating>().GetAllAsync(
                x => x.CustomerId == session.CustomerId && !x.IsDeleted,
                orderBy: q => q.OrderByDescending(x => x.RatedAt),
                enableTracking: false);

            return new ResponseDto<IList<ServiceRequestRating>>().Success(ratings);
        }
    }
}
