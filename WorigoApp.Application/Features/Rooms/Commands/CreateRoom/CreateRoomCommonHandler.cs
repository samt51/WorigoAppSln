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
            var hoteIsControll = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            if (hoteIsControll is null)
            {
                return new Response<UpdateRoomCommonResponse>().Fail(new UpdateRoomCommonResponse(), "Hotel Undifined", 400);
            }

            var roomTypeIsControll = await unitOfWork.GetReadRepository<RoomType>().GetAsync(x => x.Id == request.RoomTypeId && !x.IsDeleted);

            if (roomTypeIsControll is null)
            {
                return new Response<UpdateRoomCommonResponse>().Fail(new UpdateRoomCommonResponse(), "RoomType Is Undifined", 400);
            }

            var entityMap = mapper.Map<Room, UpdateRoomCommonRequest>(request);

            await unitOfWork.GetWriteRepository<Room>().AddAsync(entityMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateRoomCommonResponse>().Success();
            }
            return new Response<UpdateRoomCommonResponse>().Fail(new UpdateRoomCommonResponse(), "", 400);
        }
    }
}
