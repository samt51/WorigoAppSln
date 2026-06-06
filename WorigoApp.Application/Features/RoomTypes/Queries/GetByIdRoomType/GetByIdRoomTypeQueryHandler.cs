using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType
{
    public class GetByIdRoomTypeQueryHandler : BaseHandler, IRequestHandler<GetByIdRoomTypeQueryRequest, ResponseDto<GetByIdRoomTypeQueryResponse>>
    {
        public GetByIdRoomTypeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdRoomTypeQueryResponse>> Handle(GetByIdRoomTypeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<RoomType>().GetAsync(
                predicate: x => x.Id == request.Id && !x.IsDeleted,
                include: q => q.Include(rt => rt.Rooms)
            );

            var map = mapper.Map<GetByIdRoomTypeQueryResponse, RoomType>(data);

            return new ResponseDto<GetByIdRoomTypeQueryResponse>().Success(map);
        }
    }
}
