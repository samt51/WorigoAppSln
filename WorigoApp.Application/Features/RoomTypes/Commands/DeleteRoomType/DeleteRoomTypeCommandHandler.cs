using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Commands.DeleteRoomType
{
/// <summary>
/// DeleteRoomTypeCommandHandler sınıfını temsil eder.
/// </summary>
public class DeleteRoomTypeCommandHandler : BaseHandler, IRequestHandler<DeleteRoomTypeCommandRequest, ResponseDto<DeleteRoomTypeCommandResponse>>
    {
/// <summary>
/// DeleteRoomTypeCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public DeleteRoomTypeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<DeleteRoomTypeCommandResponse>> Handle(DeleteRoomTypeCommandRequest request, CancellationToken cancellationToken)
        {
            var roomType = await unitOfWork.GetReadRepository<RoomType>().GetAsync(
                predicate: x => x.Id == request.Id && !x.IsDeleted,
                include: q => q.Include(rt => rt.Rooms)
            );

            if (roomType == null)
            {
                return new ResponseDto<DeleteRoomTypeCommandResponse>().Fail("Oda tipi bulunamadı.", 404);
            }

            if (roomType.Rooms.Any(r => !r.IsDeleted))
            {
                return new ResponseDto<DeleteRoomTypeCommandResponse>().Fail("Bu oda tipine atanmış aktif odalar bulunmaktadır. Silmeden önce bu odaların tipini değiştirin.", 400);
            }

            roomType.IsDeleted = true;

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            await unitOfWork.GetWriteRepository<RoomType>().UpdateAsync(roomType);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();

            var response = new DeleteRoomTypeCommandResponse { Success = true };
            return new ResponseDto<DeleteRoomTypeCommandResponse>().Success(response);
        }
    }
}
