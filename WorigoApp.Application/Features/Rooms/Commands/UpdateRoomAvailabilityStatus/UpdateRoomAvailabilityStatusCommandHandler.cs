using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Commands.UpdateRoomAvailabilityStatus
{
    public class UpdateRoomAvailabilityStatusCommandHandler : IRequestHandler<UpdateRoomAvailabilityStatusCommandRequest, ResponseDto<bool>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRoomAvailabilityStatusCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResponseDto<bool>> Handle(UpdateRoomAvailabilityStatusCommandRequest request, CancellationToken cancellationToken)
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

            var allowedStatuses = new[] { "Normal", "DoNotDisturb", "AvailableForCleaning", "NeedCleaning", "Sleeping", "Away" };
            if (!allowedStatuses.Contains(request.Status))
            {
                return new ResponseDto<bool>().Fail("Geçersiz durum değeri.", 400);
            }

            var guestStay = await _unitOfWork.GetReadRepository<GuestStay>().FindAsync(
                x => x.Id == session.GuestStayId,
                enableTracking: true);

            if (guestStay != null)
            {
                guestStay.RoomAvailabilityStatus = request.Status;
                guestStay.RoomAvailabilityUpdatedAt = DateTime.UtcNow;
                guestStay.ModifyDate = DateTime.Now;

                // Also update Room's operational status if applicable
                var room = await _unitOfWork.GetReadRepository<Room>().FindAsync(
                    x => x.Id == guestStay.RoomId,
                    enableTracking: true);

                if (room != null)
                {
                    if (request.Status == "DoNotDisturb")
                    {
                        room.CurrentStatus = "DND";
                    }
                    else if (request.Status == "AvailableForCleaning" || request.Status == "NeedCleaning")
                    {
                        room.CurrentStatus = "NeedCleaning";
                    }
                    else
                    {
                        room.CurrentStatus = "Occupied";
                    }
                    room.ModifyDate = DateTime.Now;
                    await _unitOfWork.GetWriteRepository<Room>().UpdateAsync(room);
                }

                await _unitOfWork.GetWriteRepository<GuestStay>().UpdateAsync(guestStay);
                await _unitOfWork.SaveAsync(cancellationToken);
            }

            return new ResponseDto<bool>().Success(true);
        }
    }
}
