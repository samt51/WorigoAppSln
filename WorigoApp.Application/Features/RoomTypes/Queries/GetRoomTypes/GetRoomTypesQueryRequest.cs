using MediatR;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
    public class GetRoomTypesQueryRequest : IRequest<IList<GetRoomTypesQueryResponse>>
    {
        public GetRoomTypesQueryRequest()
        {
            
        }
    }
}
