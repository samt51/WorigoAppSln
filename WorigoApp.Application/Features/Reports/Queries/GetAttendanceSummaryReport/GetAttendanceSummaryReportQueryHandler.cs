using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Reports.Queries.GetAttendanceSummaryReport
{
    public class GetAttendanceSummaryReportQueryHandler : BaseHandler, IRequestHandler<GetAttendanceSummaryReportQueryRequest, ResponseDto<GetAttendanceSummaryReportQueryResponse>>
    {
        public GetAttendanceSummaryReportQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetAttendanceSummaryReportQueryResponse>> Handle(GetAttendanceSummaryReportQueryRequest request, CancellationToken cancellationToken)
        {
            var records = await unitOfWork.GetReadRepository<Domain.Entites.AttendanceRecord>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);

            return new ResponseDto<GetAttendanceSummaryReportQueryResponse>().Success(new GetAttendanceSummaryReportQueryResponse
            {
                TotalRecordCount = records.Count,
                LateCount = records.Count(x => x.Status == AttendanceStatusEnum.Late),
                AbsentCount = records.Count(x => x.Status == AttendanceStatusEnum.Absent),
                OnLeaveCount = records.Count(x => x.Status == AttendanceStatusEnum.OnLeave),
                TotalOvertimeMinutes = records.Sum(x => x.OvertimeMinutes)
            });
        }
    }
}
