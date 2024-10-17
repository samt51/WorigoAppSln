using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContent
{
    public class GetAllContentQueryRequest : IRequest<Response<IList<GetAllContentQueryResponse>>>
    {
    }
}
