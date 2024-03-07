using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Commands.UpdateServiceOfFeature
{
    public class UpdateServiceOfFeatureCommonHandler : BaseHandler, IRequestHandler<UpdateServiceOfFeatureCommonRequest, Response<UpdateServiceOfFeatureCommonResponse>>
    {
        public UpdateServiceOfFeatureCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateServiceOfFeatureCommonResponse>> Handle(UpdateServiceOfFeatureCommonRequest request, CancellationToken cancellationToken)
        {
            var serviceOfFeatureIsControll = await unitOfWork.GetReadRepository<ServiceOfFeature>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            if (serviceOfFeatureIsControll is null)
            {
                return new Response<UpdateServiceOfFeatureCommonResponse>().Fail(new UpdateServiceOfFeatureCommonResponse(), "undified", 400);
            }

            var map = mapper.Map<ServiceOfFeature, UpdateServiceOfFeatureCommonRequest>(request);

            await unitOfWork.GetWriteRepository<ServiceOfFeature>().UpdateAsync(map);
            unitOfWork.OpenTransaction();
            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateServiceOfFeatureCommonResponse>().Success();
            }
            return new Response<UpdateServiceOfFeatureCommonResponse>().Fail(new UpdateServiceOfFeatureCommonResponse(), "", 400);

        }
    }
}
