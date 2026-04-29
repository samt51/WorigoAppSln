using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Queries.GetByIdRoom
{
    public class GetByIdRoomQueryRequest : IRequest<ResponseDto<GetByIdRoomQueryResponse>>
    {
        public int Id { get; }
        public GetByIdRoomQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
