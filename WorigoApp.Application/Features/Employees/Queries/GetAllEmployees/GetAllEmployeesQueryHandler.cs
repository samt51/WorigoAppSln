using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
/// <summary>
/// GetAllEmployeesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllEmployeesQueryHandler : BaseHandler, IRequestHandler<GetAllEmployeesQueryRequest, ResponseDto<IList<GetAllEmployeesQueryResponse>>>
    {
/// <summary>
/// GetAllEmployeesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllEmployeesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllEmployeesQueryResponse>>> Handle(GetAllEmployeesQueryRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await unitOfWork.GetReadRepository<Employee>()
                .GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted,
                             include: x => x.Include(y => y.EmployeeType));

            var serviceRequests = await unitOfWork.GetReadRepository<ServiceRequest>()
                .GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted && 
                                  x.Status != ServiceRequestStatusEnum.Completed && 
                                  x.Status != ServiceRequestStatusEnum.Closed);

            var responseList = new List<GetAllEmployeesQueryResponse>();
            foreach (var emp in employeeList)
            {
                var activeTasks = serviceRequests.Count(x => x.AssignedEmployeeId == emp.Id);
                responseList.Add(new GetAllEmployeesQueryResponse
                {
                    Id = emp.Id,
                    Name = emp.Name,
                    Surname = emp.Surname,
                    ImageUrl = emp.ImageUrl ?? string.Empty,
                    EmployeeTypeId = emp.EmployeeTypeId ?? 0,
                    EmployeeTypeName = emp.EmployeeType?.Name ?? "Belirtilmemiş",
                    HotelId = emp.HotelId ?? 0,
                    IsAvailableForTask = emp.IsAvailableForTask,
                    Status = emp.Status,
                    ActiveTaskCount = activeTasks
                });
            }

            return new ResponseDto<IList<GetAllEmployeesQueryResponse>>().Success(responseList);
        }
    }
}
