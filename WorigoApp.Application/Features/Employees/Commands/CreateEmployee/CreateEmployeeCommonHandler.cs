using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Commands.CreateEmployee
{
/// <summary>
/// CreateEmployeeCommonHandler sınıfını temsil eder.
/// </summary>
public class CreateEmployeeCommonHandler : BaseHandler, IRequestHandler<CreateEmployeeCommonRequest, ResponseDto<CreateEmployeeCommonResponse>>
    {
/// <summary>
/// CreateEmployeeCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateEmployeeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateEmployeeCommonResponse>> Handle(CreateEmployeeCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.EmployeeTypeId);

            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId);


            var employeeMap = mapper.Map<Employee, CreateEmployeeCommonRequest>(request);
            if (request.employeeDetailRequest != null)
            {
                employeeMap.DateOfBirth = request.employeeDetailRequest.DateOfBirth;
                employeeMap.FloorNo = request.employeeDetailRequest.FloorNo;
                employeeMap.PhoneNumber = request.employeeDetailRequest.PhoneNumber;
                employeeMap.Gender = request.employeeDetailRequest.Gender;
                employeeMap.StartDateOfWork = request.employeeDetailRequest.StartDateOfWork;
                employeeMap.ExitDateOfWork = request.employeeDetailRequest.ExitDateOfWork;
                employeeMap.LastOnlineTime = request.employeeDetailRequest.LastOnlineTime;
                employeeMap.OnlineOrOfflineNow = request.employeeDetailRequest.OnlineOrOfflineNow;
            }

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            var saveEntity = await unitOfWork.GetWriteRepository<Employee>().AddAsync(employeeMap);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateEmployeeCommonResponse>().Success();
        }
    }
}
