using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommonHandler : BaseHandler, IRequestHandler<UpdateEmployeeCommonRequest, Response<UpdateEmployeeCommonResponse>>
    {
        public UpdateEmployeeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<UpdateEmployeeCommonResponse>> Handle(UpdateEmployeeCommonRequest request, CancellationToken cancellationToken)
        {
            var employeeTypeIsControll = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.Id);

            if (employeeTypeIsControll == null)
            {
                return new Response<UpdateEmployeeCommonResponse>().Fail(new UpdateEmployeeCommonResponse(), "EmployeeType Is Undifined", 200);
            }

            var employeeMap = mapper.Map<Employee, UpdateEmployeeCommonRequest>(request);

            var employeeDetailMap = mapper.Map<EmployeeDetail, EmployeeDetailRequestDto>(request.employeeDetailRequest);

            var updateEmployee = await unitOfWork.GetWriteRepository<Employee>().UpdateAsync(employeeMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                var updateEmployeeDetail = await unitOfWork.GetWriteRepository<EmployeeDetail>().UpdateAsync(employeeDetailMap);

                if (await unitOfWork.SaveAsync() > 0)
                {
                    unitOfWork.Commit();
                    return new Response<UpdateEmployeeCommonResponse>().Success();
                }
            }
            return new Response<UpdateEmployeeCommonResponse>().Fail(new UpdateEmployeeCommonResponse(), "Error", 400);
        }
    }
}
