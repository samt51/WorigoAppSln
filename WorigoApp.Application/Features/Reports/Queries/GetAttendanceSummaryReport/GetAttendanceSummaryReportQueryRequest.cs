using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetAttendanceSummaryReport
{
    public class GetAttendanceSummaryReportQueryRequest : IRequest<ResponseDto<GetAttendanceSummaryReportQueryResponse>>
    {
        public int HotelId { get; set; }
    }
}
