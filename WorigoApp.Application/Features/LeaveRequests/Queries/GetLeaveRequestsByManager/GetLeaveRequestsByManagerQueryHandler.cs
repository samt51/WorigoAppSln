using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.LeaveRequests.Queries.GetLeaveRequestsByManager
{
    public class GetLeaveRequestsByManagerQueryHandler : BaseHandler, IRequestHandler<GetLeaveRequestsByManagerQueryRequest, ResponseDto<IList<GetLeaveRequestsByManagerQueryResponse>>>
    {
        public GetLeaveRequestsByManagerQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetLeaveRequestsByManagerQueryResponse>>> Handle(GetLeaveRequestsByManagerQueryRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await unitOfWork.GetReadRepository<LeaveRequest>().GetAllAsync(
                x => (request.IsHrView ? x.HrEmployeeId == request.ManagerEmployeeId : x.ManagerEmployeeId == request.ManagerEmployeeId) && !x.IsDeleted,
                include: x => x.Include(y => y.Employee).Include(y => y.Department),
                orderBy: x => x.OrderByDescending(y => y.RequestedAt));

            var response = leaveRequests.Select(x => new GetLeaveRequestsByManagerQueryResponse
            {
                Id = x.Id,
                EmployeeName = $"{x.Employee.Name} {x.Employee.Surname}".Trim(),
                DepartmentName = x.Department?.Name,
                Title = x.Title,
                LeaveType = x.LeaveType,
                Status = x.Status,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                TotalDayCount = x.TotalDayCount,
                RequestedAt = x.RequestedAt
            }).ToList();

            return new ResponseDto<IList<GetLeaveRequestsByManagerQueryResponse>>().Success(response);
        }
    }
}
