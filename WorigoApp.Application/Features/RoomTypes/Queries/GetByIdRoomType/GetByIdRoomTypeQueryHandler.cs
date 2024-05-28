using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
    public class GetByIdRoomTypeQueryHandler : BaseHandler, IRequestHandler<GetByIdRoomTypeQueryRequest, Response<GetByIdRoomTypeQueryResponse>>
    {
        public GetByIdRoomTypeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdRoomTypeQueryResponse>> Handle(GetByIdRoomTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<RoomType>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdRoomTypeQueryResponse, RoomType>(data);

            return new Response<GetByIdRoomTypeQueryResponse>().Success(map);
        }
    }
}
