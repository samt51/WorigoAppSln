using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetPerformanceSummaryReport
{
    public class GetPerformanceSummaryReportQueryRequest : IRequest<ResponseDto<GetPerformanceSummaryReportQueryResponse>>
    {
        public int HotelId { get; set; }
    }
}
