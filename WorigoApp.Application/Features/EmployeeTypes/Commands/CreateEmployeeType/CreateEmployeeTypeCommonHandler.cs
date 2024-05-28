using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType
{
    public class CreateEmployeeTypeCommonHandler : BaseHandler, IRequestHandler<CreateEmployeeTypeCommonRequest, Response<CreateEmployeeTypeCommonResponse>>
    {
        public CreateEmployeeTypeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateEmployeeTypeCommonResponse>> Handle(CreateEmployeeTypeCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.DepartmentId);

            var creatMapper = mapper.Map<EmployeeType, CreateEmployeeTypeCommonRequest>(request);

            unitOfWork.OpenTransaction();

            await unitOfWork.GetWriteRepository<EmployeeType>().AddAsync(creatMapper);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateEmployeeTypeCommonResponse>().Success();

        }
    }
}
