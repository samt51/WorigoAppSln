using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

using WorigoApp.Application.Interfaces.AutoMapper;

namespace WorigoApp.Application.Features.Restaurants.Commands.RejectRestaurantReservation
{
    public class RejectRestaurantReservationCommandHandler : BaseHandler, IRequestHandler<RejectRestaurantReservationCommandRequest, ResponseDto<RejectRestaurantReservationResponse>>
    {
        public RejectRestaurantReservationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<RejectRestaurantReservationResponse>> Handle(RejectRestaurantReservationCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await unitOfWork.GetReadRepository<Users>().FindAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(x => x.Employee),
                enableTracking: false);

            if (user is null || user.Employee is null) return new ResponseDto<RejectRestaurantReservationResponse>().Fail("Personel kaydı bulunamadı.", 401);

            var reservation = await unitOfWork.GetReadRepository<RestaurantReservation>().FindAsync(
                x => x.Id == request.Id && x.HotelId == user.Employee.HotelId && !x.IsDeleted,
                enableTracking: true);

            if (reservation is null) return new ResponseDto<RejectRestaurantReservationResponse>().Fail("Rezervasyon bulunamadı.", 404);

            reservation.Status = "Rejected";
            reservation.ModifyDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<RestaurantReservation>().UpdateAsync(reservation);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<RejectRestaurantReservationResponse>().Success(new RejectRestaurantReservationResponse
            {
                ReservationId = reservation.Id,
                GuestStayId = reservation.GuestStayId
            });
        }
    }
}
