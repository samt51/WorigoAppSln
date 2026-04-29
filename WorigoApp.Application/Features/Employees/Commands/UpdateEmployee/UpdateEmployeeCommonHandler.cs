using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommonHandler : BaseHandler, IRequestHandler<UpdateEmployeeCommonRequest, ResponseDto<UpdateEmployeeCommonResponse>>
    {
        public UpdateEmployeeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateEmployeeCommonResponse>> Handle(UpdateEmployeeCommonRequest request, CancellationToken cancellationToken)
        {
            var employeeTypeIsControll = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var employeeMap = mapper.Map<Employee, UpdateEmployeeCommonRequest>(request);

            var employeeDetailMap = mapper.Map<EmployeeDetail, EmployeeDetailRequestDto>(request.employeeDetailRequest);

            await unitOfWork.GetWriteRepository<Employee>().UpdateAsync(employeeMap);

            await unitOfWork.GetWriteRepository<EmployeeDetail>().UpdateAsync(employeeDetailMap);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateEmployeeCommonResponse>().Success();

        }
    }
}
