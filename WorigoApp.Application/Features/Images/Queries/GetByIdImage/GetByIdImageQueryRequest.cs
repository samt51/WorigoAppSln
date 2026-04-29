using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Queries.GetByIdImage
{
    public class GetByIdImageQueryRequest : IRequest<ResponseDto<GetByIdImageQueryResponse>>
    {
        public int Id { get; }
        public GetByIdImageQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
