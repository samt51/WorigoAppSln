using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Rooms.Commands.CreateRoom
{
    public class UpdateRoomCommonHandler : BaseHandler, IRequestHandler<UpdateRoomCommonRequest, Response<UpdateRoomCommonResponse>>
    {
        public UpdateRoomCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateRoomCommonResponse>> Handle(UpdateRoomCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            await unitOfWork.GetReadRepository<RoomType>().GetAsync(x => x.Id == request.RoomTypeId && !x.IsDeleted);

            var entityMap = mapper.Map<Room, UpdateRoomCommonRequest>(request);

            await unitOfWork.GetWriteRepository<Room>().AddAsync(entityMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdateRoomCommonResponse>().Success();
        }
    }
}
