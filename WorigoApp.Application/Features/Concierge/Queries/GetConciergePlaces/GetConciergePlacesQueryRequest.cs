using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergePlaces
{
    public class GetConciergePlacesQueryRequest : IRequest<ResponseDto<IList<ConciergePlace>>>
    {
        public string SessionToken { get; set; } = string.Empty;
        public string? Category { get; set; }
    }
}
