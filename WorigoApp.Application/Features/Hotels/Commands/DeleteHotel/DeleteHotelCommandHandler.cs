using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Commands.DeleteHotel
{
    public class DeleteHotelCommandHandler : BaseHandler, IRequestHandler<DeleteHotelCommandRequest, ResponseDto<DeleteHotelCommandResponse>>
    {
        public DeleteHotelCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<DeleteHotelCommandResponse>> Handle(DeleteHotelCommandRequest request, CancellationToken cancellationToken)
        {
            var hotel = await unitOfWork.GetReadRepository<Hotel>().FindAsync(
                x => x.Id == request.Id && !x.IsDeleted,
                enableTracking: true);

            if (hotel is null)
            {
                return new ResponseDto<DeleteHotelCommandResponse>().Fail(
                    new List<string> { "Otel bulunamadi." },
                    404);
            }

            hotel.IsDeleted = true;
            hotel.IsActive = false;
            hotel.ModifyDate = DateTime.Now;

            await unitOfWork.GetWriteRepository<Hotel>().SoftDeleteAsync(hotel);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<DeleteHotelCommandResponse>().Success(new DeleteHotelCommandResponse
            {
                Id = hotel.Id
            });
        }
    }
}
