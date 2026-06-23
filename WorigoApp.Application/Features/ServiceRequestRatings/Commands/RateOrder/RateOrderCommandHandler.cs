using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.RateOrder
{
    public class RateOrderCommandHandler : IRequestHandler<RateOrderCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RateOrderCommandHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(RateOrderCommandRequest request, CancellationToken cancellationToken)
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

            var order = await _unitOfWork.GetReadRepository<Order>()
                .FindAsync(x => x.Id == request.OrderId && x.GuestStayId == session.GuestStayId && !x.IsDeleted);

            if (order is null) return new ResponseDto<bool>().Fail("Sipariş bulunamadı.", 404);

            var alreadyExists = await _unitOfWork.GetReadRepository<ServiceRequestRating>()
                .FindAsync(x => x.OrderId == request.OrderId && x.CustomerId == session.CustomerId && !x.IsDeleted);

            if (alreadyExists is not null) return new ResponseDto<bool>().Fail("Bu sipariş daha önce değerlendirilmiş.", 400);

            var rating = new ServiceRequestRating
            {
                OrderId = request.OrderId,
                CustomerId = session.CustomerId,
                SpeedScore = request.SpeedScore,
                QualityScore = request.QualityScore,
                StaffScore = request.StaffScore,
                OverallScore = request.OverallScore ?? ((request.SpeedScore + request.QualityScore + request.StaffScore) / 3m),
                Comment = request.Comment,
                RatedAt = DateTime.UtcNow,
                CreatedDate = DateTime.Now,
                IsActive = true
            };

            await _unitOfWork.GetWriteRepository<ServiceRequestRating>().AddAsync(rating);
            await _unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }
    }
}
