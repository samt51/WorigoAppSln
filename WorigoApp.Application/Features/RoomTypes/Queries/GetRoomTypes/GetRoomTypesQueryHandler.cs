using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes
{
    public class GetRoomTypesQueryHandler : BaseHandler, IRequestHandler<GetRoomTypesQueryRequest, IList<GetRoomTypesQueryResponse>>
    {
        public GetRoomTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetRoomTypesQueryResponse>> Handle(GetRoomTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await unitOfWork.GetReadRepository<RoomType>().GetAllAsync();
            return mapper.Map<GetRoomTypesQueryResponse, RoomType>(list);
        }
    }
}
