using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Commands.CancelRestaurantReservation
{
    public class CancelRestaurantReservationCommandRequest : IRequest<ResponseDto<bool>>
    {
        public int Id { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
