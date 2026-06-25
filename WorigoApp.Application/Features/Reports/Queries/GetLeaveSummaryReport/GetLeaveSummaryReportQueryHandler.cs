using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport
{
/// <summary>
/// GetLeaveSummaryReportQueryHandler sınıfını temsil eder.
/// </summary>
public class GetLeaveSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetLeaveSummaryReportQueryRequest, ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>>
    {
/// <summary>
/// GetLeaveSummaryReportQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetLeaveSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>> Handle(GetLeaveSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            if (!await CheckHotelAccessAsync(request.HotelId))
            {
                return new ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>().Fail("Bu işlem için yetkiniz bulunmamaktadır.", 403);
            }

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
