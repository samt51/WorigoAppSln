using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetByIdContent
{
    public class GetByIdContentQueryRequest : IRequest<Response<GetByIdContentQueryResponse>>
    {
        public int Id { get; }
        public GetByIdContentQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
