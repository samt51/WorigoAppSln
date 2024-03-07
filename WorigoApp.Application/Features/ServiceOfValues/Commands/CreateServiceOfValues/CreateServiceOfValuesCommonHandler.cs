using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfValues.Commands.CreateServiceOfValues
{
    public class UpdateServiceOfValuesCommonHandler : BaseHandler, IRequestHandler<UpdateServiceOfValuesCommonRequest, Response<UpdateServiceOfValuesCommonResponse>>
    {
        public UpdateServiceOfValuesCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateServiceOfValuesCommonResponse>> Handle(UpdateServiceOfValuesCommonRequest request, CancellationToken cancellationToken)
        {
            var entityMap = mapper.Map<ServiceOfValue, UpdateServiceOfValuesCommonRequest>(request);

            await unitOfWork.GetWriteRepository<ServiceOfValue>().AddAsync(entityMap);

            unitOfWork.OpenTransaction();

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<UpdateServiceOfValuesCommonResponse>().Success();
            }
            return new Response<UpdateServiceOfValuesCommonResponse>().Fail(new UpdateServiceOfValuesCommonResponse(), "", 400);
        }
    }
}
