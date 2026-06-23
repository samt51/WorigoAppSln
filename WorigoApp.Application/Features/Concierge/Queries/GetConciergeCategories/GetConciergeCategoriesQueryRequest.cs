using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Concierge.Queries.GetConciergeCategories
{
    public class GetConciergeCategoriesQueryRequest : IRequest<ResponseDto<IList<string>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
