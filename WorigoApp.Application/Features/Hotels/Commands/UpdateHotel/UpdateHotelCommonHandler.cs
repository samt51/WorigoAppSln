using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Commands.UpdateHotel
{
    public class UpdateHotelCommonHandler : BaseHandler, IRequestHandler<UpdateHotelCommonRequest, Response<UpdateHotelCommonResponse>>
    {
        public UpdateHotelCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateHotelCommonResponse>> Handle(UpdateHotelCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var mapEntity = mapper.Map<Hotel, UpdateHotelCommonRequest>(request);

            await unitOfWork.GetWriteRepository<Hotel>().UpdateAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<UpdateHotelCommonResponse>().Success();

        }
    }
}
