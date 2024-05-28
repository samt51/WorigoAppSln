using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Queries.GetByIdImage
{
    public class GetByIdImageQueryRequest : IRequest<Response<GetByIdImageQueryResponse>>
    {
        public int Id { get; }
        public GetByIdImageQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
