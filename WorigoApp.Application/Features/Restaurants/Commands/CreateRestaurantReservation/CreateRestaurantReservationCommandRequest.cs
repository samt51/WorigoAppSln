using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Commands.CreateRestaurantReservation
{
    public class CreateRestaurantReservationCommandRequest : IRequest<ResponseDto<RestaurantReservation>>
    {
        public string SessionToken { get; set; } = string.Empty;
        public int RestaurantId { get; set; }
        public DateTime ReservationDate { get; set; }
        public string TimeSlot { get; set; } = string.Empty;
        public int GuestCount { get; set; }
        public string? Note { get; set; }
    }
}
