using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRoomAvailabilityStatus
{
    public class GetRoomAvailabilityStatusQueryHandler : IRequestHandler<GetRoomAvailabilityStatusQueryRequest, ResponseDto<RoomAvailabilityStatusResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetRoomAvailabilityStatusQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<RoomAvailabilityStatusResponse>> Handle(GetRoomAvailabilityStatusQueryRequest request, CancellationToken cancellationToken)
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

            if (session is null) return new ResponseDto<RoomAvailabilityStatusResponse>().Fail("Oturum bulunamadı veya süresi doldu.", 404);

            return new ResponseDto<RoomAvailabilityStatusResponse>().Success(new RoomAvailabilityStatusResponse
            {
                GuestStayId = session.GuestStayId,
                Status = session.GuestStay.RoomAvailabilityStatus ?? "Normal",
                UpdatedAt = session.GuestStay.RoomAvailabilityUpdatedAt ?? session.GuestStay.CreatedDate
            });
        }
    }
}
