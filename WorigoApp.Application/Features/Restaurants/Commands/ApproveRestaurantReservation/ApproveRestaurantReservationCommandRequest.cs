using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Commands.ApproveRestaurantReservation
{
    public class ApproveRestaurantReservationCommandRequest : IRequest<ResponseDto<ApproveRestaurantReservationResponse>>
    {
        public int Id { get; set; }
    }
}
