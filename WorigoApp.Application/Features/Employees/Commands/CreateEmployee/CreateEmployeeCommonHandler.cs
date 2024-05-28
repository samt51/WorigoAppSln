using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommonHandler : BaseHandler, IRequestHandler<CreateEmployeeCommonRequest, Response<CreateEmployeeCommonResponse>>
    {
        public CreateEmployeeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateEmployeeCommonResponse>> Handle(CreateEmployeeCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.EmployeeTypeId);

            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId);


            var employeeMap = mapper.Map<Employee, CreateEmployeeCommonRequest>(request);

            unitOfWork.OpenTransaction();
            var saveEntity = await unitOfWork.GetWriteRepository<Employee>().AddAsync(employeeMap);

            var employeeDetailMap = mapper.Map<EmployeeDetail, EmployeeDetailRequestDto>(request.employeeDetailRequest);

            employeeDetailMap.EmployeeId = saveEntity.Id;

            await unitOfWork.GetWriteRepository<EmployeeDetail>().AddAsync(employeeDetailMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateEmployeeCommonResponse>().Success();
        }
    }
}
