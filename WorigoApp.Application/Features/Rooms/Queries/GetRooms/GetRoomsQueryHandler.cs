using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
    public class GetRoomsQueryHandler : BaseHandler, IRequestHandler<GetRoomsQueryRequest, IList<GetRoomsQueryResponse>>
    {
        public GetRoomsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetRoomsQueryResponse>> Handle(GetRoomsQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<Room>().GetAllAsync();
            
            return mapper.Map<GetRoomsQueryResponse, Room>(list);
        }
    }
}
