using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler : BaseHandler, IRequestHandler<CreateServiceCommandRequest, Response<CreateServiceCommandResponse>>
    {
        public CreateServiceCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
        public async Task<Response<CreateServiceCommandResponse>> Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var map = mapper.Map<Service, CreateServiceCommandRequest>(request);

            unitOfWork.OpenTransaction();
            var entity = await unitOfWork.GetWriteRepository<Service>().AddAsync(map);
            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                var resultMap = mapper.Map<CreateServiceCommandResponse, Service>(entity);
                return new Response<CreateServiceCommandResponse>().Success(resultMap);
            }
            return new Response<CreateServiceCommandResponse>().Fail(null, new List<string>(), 400);

        }
    }
}
