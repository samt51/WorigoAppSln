using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergeCategories
{
    public class GetConciergeCategoriesQueryHandler : IRequestHandler<GetConciergeCategoriesQueryRequest, ResponseDto<IList<string>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetConciergeCategoriesQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<IList<string>>> Handle(GetConciergeCategoriesQueryRequest request, CancellationToken cancellationToken)
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

            var places = await _unitOfWork.GetReadRepository<ConciergePlace>().GetAllAsync(
                x => x.HotelId == session.GuestStay.HotelId && x.IsActive && !x.IsDeleted,
                enableTracking: false);

            var categories = places.Select(x => x.Category).Distinct().ToList();

            return new ResponseDto<IList<string>>().Success(categories);
        }
    }
}
