using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Commands.CreateServiceOfFeature
{
    public class UpdateServiceOfFeatureCommonHandler : BaseHandler, IRequestHandler<UpdateServiceOfFeatureCommonRequest, Response<CreateServiceOfFeatureCommonResponse>>
    {
        public UpdateServiceOfFeatureCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateServiceOfFeatureCommonResponse>> Handle(UpdateServiceOfFeatureCommonRequest request, CancellationToken cancellationToken)
        {
            var serviceIsControll = await unitOfWork.GetReadRepository<Service>().GetAsync(x => x.Id == request.ServiceId && !x.IsDeleted);

            if (serviceIsControll is null)
            {
                return new Response<CreateServiceOfFeatureCommonResponse>().Fail(new CreateServiceOfFeatureCommonResponse(), "undified", 400);
            }

            var map = mapper.Map<ServiceOfFeature, UpdateServiceOfFeatureCommonRequest>(request);

            await unitOfWork.GetWriteRepository<ServiceOfFeature>().AddAsync(map);
            unitOfWork.OpenTransaction();
            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<CreateServiceOfFeatureCommonResponse>().Success();
            }
            return new Response<CreateServiceOfFeatureCommonResponse>().Fail(new CreateServiceOfFeatureCommonResponse(), "", 400);

        }
    }
}
