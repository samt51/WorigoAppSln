using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Restaurants.Queries.GetRestaurants
{
    public class GetRestaurantsQueryRequest : IRequest<ResponseDto<IList<Restaurant>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
