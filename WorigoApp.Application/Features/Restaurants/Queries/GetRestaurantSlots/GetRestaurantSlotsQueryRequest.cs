using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantSlots
{
    public class GetRestaurantSlotsQueryRequest : IRequest<ResponseDto<IList<string>>>
    {
        public int RestaurantId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string SessionToken { get; set; } = string.Empty;
    }
}
