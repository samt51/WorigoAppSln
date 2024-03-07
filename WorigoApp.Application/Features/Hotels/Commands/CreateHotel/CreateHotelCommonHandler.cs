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
            var companyIsControll = await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.Companyid && !x.IsDeleted);

            if (companyIsControll is null)
            {
                return new Response<CreateHotelCommonResponse>().Fail(new CreateHotelCommonResponse(), "Company Is Undifined", 400);
            }

            var mapEntity = mapper.Map<Hotel, CreateHotelCommonRequest>(request);

            await unitOfWork.GetWriteRepository<Hotel>().AddAsync(mapEntity);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();

                return new Response<CreateHotelCommonResponse>().Success();
            }
            return new Response<CreateHotelCommonResponse>().Fail(new CreateHotelCommonResponse(), "", 400);
        }
    }
}
