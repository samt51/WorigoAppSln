using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommonHandler : BaseHandler, IRequestHandler<CreateHotelCommonRequest, Response<CreateHotelCommonResponse>>
    {
        public CreateHotelCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateHotelCommonResponse>> Handle(CreateHotelCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.Companyid && !x.IsDeleted);

            var mapEntity = mapper.Map<Hotel, CreateHotelCommonRequest>(request);

            await unitOfWork.GetWriteRepository<Hotel>().AddAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateHotelCommonResponse>().Success();

        }
    }
}
