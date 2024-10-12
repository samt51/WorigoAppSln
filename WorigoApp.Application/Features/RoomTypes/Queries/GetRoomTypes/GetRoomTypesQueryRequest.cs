using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
    public class GetRoomTypesQueryRequest : IRequest<Response<IList<GetRoomTypesQueryResponse>>>
    {
        public GetRoomTypesQueryRequest()
        {
            
        }
    }
}
