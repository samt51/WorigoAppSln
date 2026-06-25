using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Commands.ToggleRoomTypeStatus
{
/// <summary>
/// ToggleRoomTypeStatusCommandHandler sınıfını temsil eder.
/// </summary>
public class ToggleRoomTypeStatusCommandHandler : BaseHandler, IRequestHandler<ToggleRoomTypeStatusCommandRequest, ResponseDto<ToggleRoomTypeStatusCommandResponse>>
    {
/// <summary>
/// ToggleRoomTypeStatusCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public ToggleRoomTypeStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<ToggleRoomTypeStatusCommandResponse>> Handle(ToggleRoomTypeStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var roomType = await unitOfWork.GetReadRepository<RoomType>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            if (roomType == null)
            {
                return new ResponseDto<ToggleRoomTypeStatusCommandResponse>().Fail("Oda tipi bulunamadı.", 404);
            }

            roomType.IsActive = !roomType.IsActive;

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            await unitOfWork.GetWriteRepository<RoomType>().UpdateAsync(roomType);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();

            var response = new ToggleRoomTypeStatusCommandResponse
            {
                Success = true,
                NewStatus = roomType.IsActive
            };
            return new ResponseDto<ToggleRoomTypeStatusCommandResponse>().Success(response);
        }
    }
}
