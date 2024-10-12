using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType
{
    public class CreateRoomTypeCommonHandler : BaseHandler, IRequestHandler<CreateRoomTypeCommonRequest, Response<CreateRoomTypeCommonResponse>>
    {
        public CreateRoomTypeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateRoomTypeCommonResponse>> Handle(CreateRoomTypeCommonRequest request, CancellationToken cancellationToken)
        {
            var saveMap = mapper.Map<RoomType, CreateRoomTypeCommonRequest>(request);

            await unitOfWork.GetWriteRepository<RoomType>().AddAsync(saveMap);
            unitOfWork.OpenTransaction();

            unitOfWork.Commit();

            return new Response<CreateRoomTypeCommonResponse>().Success();

        }
    }
}
