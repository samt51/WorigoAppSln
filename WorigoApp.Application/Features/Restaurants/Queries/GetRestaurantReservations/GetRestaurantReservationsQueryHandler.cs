using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

using WorigoApp.Application.Interfaces.AutoMapper;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantReservations
{
/// <summary>
/// GetRestaurantReservationsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetRestaurantReservationsQueryHandler : BaseHandler, IRequestHandler<GetRestaurantReservationsQueryRequest, ResponseDto<IList<RestaurantReservation>>>
    {
/// <summary>
/// GetRestaurantReservationsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetRestaurantReservationsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<RestaurantReservation>>> Handle(GetRestaurantReservationsQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await unitOfWork.GetReadRepository<Users>().FindAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(x => x.Employee),
                enableTracking: false);

            if (user is null || user.Employee is null) return new ResponseDto<IList<RestaurantReservation>>().Fail("Personel kaydı bulunamadı.", 401);

            var reservations = await unitOfWork.GetReadRepository<RestaurantReservation>().GetAllAsync(
                x => x.HotelId == user.Employee.HotelId && !x.IsDeleted,
                include: q => q.Include(x => x.Restaurant).Include(x => x.Customer).Include(x => x.GuestStay).ThenInclude(x => x.Room),
                orderBy: q => q.OrderByDescending(x => x.ReservationDate),
                enableTracking: false);

            return new ResponseDto<IList<RestaurantReservation>>().Success(reservations);
        }
    }
}
