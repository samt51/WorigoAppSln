using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.UserFeature.Queries.GetByIdUser
{
    public class GetByIdUserQueryRequest : IRequest<Response<GetByIdUserQueryResponse>>
    {
        public GetByIdUserQueryRequest(int id)
        {

            Id = id;

        }
        public int Id { get; }

    }
}

