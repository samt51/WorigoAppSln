using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Commands.ApproveRestaurantReservation
{
/// <summary>
/// ApproveRestaurantReservationCommandHandler sınıfını temsil eder.
/// </summary>
public class ApproveRestaurantReservationCommandHandler : BaseHandler, IRequestHandler<ApproveRestaurantReservationCommandRequest, ResponseDto<ApproveRestaurantReservationResponse>>
    {
/// <summary>
/// ApproveRestaurantReservationCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public ApproveRestaurantReservationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<ApproveRestaurantReservationResponse>> Handle(ApproveRestaurantReservationCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await unitOfWork.GetReadRepository<Users>().FindAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(x => x.Employee),
                enableTracking: false);

            if (user is null || user.Employee is null) return new ResponseDto<ApproveRestaurantReservationResponse>().Fail("Personel kaydı bulunamadı.", 401);

            var reservation = await unitOfWork.GetReadRepository<RestaurantReservation>().FindAsync(
                x => x.Id == request.Id && x.HotelId == user.Employee.HotelId && !x.IsDeleted,
                enableTracking: true);

            if (reservation is null) return new ResponseDto<ApproveRestaurantReservationResponse>().Fail("Rezervasyon bulunamadı.", 404);

            reservation.Status = "Approved";
            reservation.ApprovedAt = DateTime.UtcNow;
            reservation.ApprovedByEmployeeId = user.Employee.Id;
            reservation.ModifyDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<RestaurantReservation>().UpdateAsync(reservation);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<ApproveRestaurantReservationResponse>().Success(new ApproveRestaurantReservationResponse
            {
                ReservationId = reservation.Id,
                GuestStayId = reservation.GuestStayId
            });
        }
    }
}
