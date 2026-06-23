using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.RateServiceRequest
{
    public class RateServiceRequestCommandHandler : IRequestHandler<RateServiceRequestCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RateServiceRequestCommandHandler(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(RateServiceRequestCommandRequest request, CancellationToken cancellationToken)
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

            var serviceRequest = await _unitOfWork.GetReadRepository<ServiceRequest>()
                .FindAsync(x => x.Id == request.ServiceRequestId && x.GuestStayId == session.GuestStayId && !x.IsDeleted);

            if (serviceRequest is null) return new ResponseDto<bool>().Fail("Servis talebi bulunamadı.", 404);

            var alreadyExists = await _unitOfWork.GetReadRepository<ServiceRequestRating>()
                .FindAsync(x => x.ServiceRequestId == request.ServiceRequestId && x.CustomerId == session.CustomerId && !x.IsDeleted);

            if (alreadyExists is not null) return new ResponseDto<bool>().Fail("Bu servis talebi daha önce değerlendirilmiş.", 400);

            var rating = new ServiceRequestRating
            {
                ServiceRequestId = request.ServiceRequestId,
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
