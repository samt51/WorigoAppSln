using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType
{
    public class CreateRoomTypeCommandHandler : BaseHandler, IRequestHandler<CreateRoomTypeCommandRequest, ResponseDto<CreateRoomTypeCommandResponse>>
    {
        public CreateRoomTypeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateRoomTypeCommandResponse>> Handle(CreateRoomTypeCommandRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return new ResponseDto<CreateRoomTypeCommandResponse>().Fail("Oda tipi adı boş olamaz.", 400);
            }

            if (request.Capacity < 1)
            {
                return new ResponseDto<CreateRoomTypeCommandResponse>().Fail("Kapasite en az 1 olmalıdır.", 400);
            }

            if (request.BasePrice < 0)
            {
                return new ResponseDto<CreateRoomTypeCommandResponse>().Fail("Taban fiyat 0 veya daha büyük olmalıdır.", 400);
            }

            var hotel = await unitOfWork.GetReadRepository<Hotel>().FindAsync(x => x.Id == request.HotelId && !x.IsDeleted);
            if (hotel == null)
            {
                return new ResponseDto<CreateRoomTypeCommandResponse>().Fail("Geçersiz otel.", 404);
            }

            var existingRoomTypes = await unitOfWork.GetReadRepository<RoomType>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);
            if (existingRoomTypes.Any(x => string.Equals(x.Name.Trim(), request.Name.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return new ResponseDto<CreateRoomTypeCommandResponse>().Fail("Bu isimde bir oda tipi zaten mevcut.", 400);
            }

            var newRoomType = new RoomType
            {
                HotelId = request.HotelId,
                Name = request.Name.Trim(),
                Description = request.Description?.Trim(),
                Capacity = request.Capacity,
                BasePrice = request.BasePrice,
                DisplayOrder = request.DisplayOrder,
                IsActive = request.IsActive,
                IsDeleted = false
            };

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            var saved = await unitOfWork.GetWriteRepository<RoomType>().AddAsync(newRoomType);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();

            var response = new CreateRoomTypeCommandResponse
            {
                Id = saved.Id,
                Name = saved.Name
            };

            return new ResponseDto<CreateRoomTypeCommandResponse>().Success(response);
        }
    }
}
