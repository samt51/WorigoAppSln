using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Commands.RejectRestaurantReservation
{
    public class RejectRestaurantReservationCommandRequest : IRequest<ResponseDto<RejectRestaurantReservationResponse>>
    {
        public int Id { get; set; }
    }
}
