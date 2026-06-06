using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Commands.UpdateRoomType
{
    public class UpdateRoomTypeCommandHandler : BaseHandler, IRequestHandler<UpdateRoomTypeCommandRequest, ResponseDto<UpdateRoomTypeCommandResponse>>
    {
        public UpdateRoomTypeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateRoomTypeCommandResponse>> Handle(UpdateRoomTypeCommandRequest request, CancellationToken cancellationToken)
        {
            var roomType = await unitOfWork.GetReadRepository<RoomType>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            if (roomType == null)
            {
                return new ResponseDto<UpdateRoomTypeCommandResponse>().Fail("Oda tipi bulunamadı.", 404);
            }

            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return new ResponseDto<UpdateRoomTypeCommandResponse>().Fail("Oda tipi adı boş olamaz.", 400);
            }

            if (request.Capacity < 1)
            {
                return new ResponseDto<UpdateRoomTypeCommandResponse>().Fail("Kapasite en az 1 olmalıdır.", 400);
            }

            if (request.BasePrice < 0)
            {
                return new ResponseDto<UpdateRoomTypeCommandResponse>().Fail("Taban fiyat 0 veya daha büyük olmalıdır.", 400);
            }

            var existingRoomTypes = await unitOfWork.GetReadRepository<RoomType>().GetAllAsync(x => x.HotelId == request.HotelId && x.Id != request.Id && !x.IsDeleted);
            if (existingRoomTypes.Any(x => string.Equals(x.Name.Trim(), request.Name.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return new ResponseDto<UpdateRoomTypeCommandResponse>().Fail("Bu isimde bir oda tipi zaten mevcut.", 400);
            }

            roomType.Name = request.Name.Trim();
            roomType.Description = request.Description?.Trim();
            roomType.Capacity = request.Capacity;
            roomType.BasePrice = request.BasePrice;
            roomType.DisplayOrder = request.DisplayOrder;
            roomType.IsActive = request.IsActive;

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            await unitOfWork.GetWriteRepository<RoomType>().UpdateAsync(roomType);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();

            var response = new UpdateRoomTypeCommandResponse { Success = true };
            return new ResponseDto<UpdateRoomTypeCommandResponse>().Success(response);
        }
    }
}
