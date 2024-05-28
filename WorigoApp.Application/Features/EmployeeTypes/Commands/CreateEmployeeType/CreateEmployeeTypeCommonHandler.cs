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
            var departmentIsControll = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.DepartmentId);

            if (departmentIsControll is null)
            {
                return new Response<CreateEmployeeTypeCommonResponse>().Fail(new CreateEmployeeTypeCommonResponse(), "Department Undifined", 400);

            }

            var creatMapper = mapper.Map<EmployeeType, CreateEmployeeTypeCommonRequest>(request);

            unitOfWork.OpenTransaction();

            var saveEntity = await unitOfWork.GetWriteRepository<EmployeeType>().AddAsync(creatMapper);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<CreateEmployeeTypeCommonResponse>().Success();
            }
            return new Response<CreateEmployeeTypeCommonResponse>().Fail(new CreateEmployeeTypeCommonResponse(), "", 400);
        }
    }
}
