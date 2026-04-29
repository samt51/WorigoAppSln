using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport
{
    public class GetLeaveSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetLeaveSummaryReportQueryRequest, ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>>
    {
        public GetLeaveSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>> Handle(GetLeaveSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            var departments = await unitOfWork.GetReadRepository<Department>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);
            var leaveRequests = await unitOfWork.GetReadRepository<LeaveRequest>().GetAllAsync(
                x => x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x.Include(y => y.Department));

            var response = departments.Select(department =>
            {
                var departmentLeaves = leaveRequests.Where(x => x.DepartmentId == department.Id).ToList();
                return new GetLeaveSummaryReportQueryResponse
                {
                    DepartmentId = department.Id,
                    DepartmentName = department.Name,
                    TotalLeaveRequestCount = departmentLeaves.Count,
                    PendingLeaveRequestCount = departmentLeaves.Count(x => x.Status == LeaveRequestStatusEnum.PendingManagerApproval || x.Status == LeaveRequestStatusEnum.PendingHrApproval),
                    ApprovedLeaveRequestCount = departmentLeaves.Count(x => x.Status == LeaveRequestStatusEnum.Approved),
                    TotalRequestedLeaveDays = departmentLeaves.Sum(x => x.TotalDayCount)
                };
            }).OrderByDescending(x => x.TotalLeaveRequestCount).ToList();

            return new ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>().Success(response);
        }
    }
}
