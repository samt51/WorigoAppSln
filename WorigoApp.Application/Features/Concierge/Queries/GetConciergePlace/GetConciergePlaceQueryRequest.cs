using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergePlace
{
    public class GetConciergePlaceQueryRequest : IRequest<ResponseDto<ConciergePlace>>
    {
        public int Id { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
