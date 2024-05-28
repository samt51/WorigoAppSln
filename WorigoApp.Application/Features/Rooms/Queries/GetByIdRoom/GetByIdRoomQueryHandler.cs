using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Queries.GetByIdRoom
{
    public class GetByIdRoomQueryHandler : BaseHandler, IRequestHandler<GetByIdRoomQueryRequest, Response<GetByIdRoomQueryResponse>>
    {
        public GetByIdRoomQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdRoomQueryResponse>> Handle(GetByIdRoomQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Room>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdRoomQueryResponse, Room>(data);

            return new Response<GetByIdRoomQueryResponse>().Success(map);
        }
    }
}
