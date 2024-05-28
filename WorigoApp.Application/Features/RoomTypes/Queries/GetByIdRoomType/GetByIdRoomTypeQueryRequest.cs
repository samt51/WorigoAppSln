using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
    public class GetByIdRoomTypeQueryRequest : IRequest<Response<GetByIdRoomTypeQueryResponse>>
    {
        public GetByIdRoomTypeQueryRequest(int id)
        {
            this.Id = id;
        }
        public int Id { get; }
    }
}
