using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryHandler : BaseHandler, IRequestHandler<GetAllEmployeesQueryRequest, ResponseDto<IList<GetAllEmployeesQueryResponse>>>
    {
        public GetAllEmployeesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllEmployeesQueryResponse>>> Handle(GetAllEmployeesQueryRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await unitOfWork.GetReadRepository<Employee>()
                .GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);

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
