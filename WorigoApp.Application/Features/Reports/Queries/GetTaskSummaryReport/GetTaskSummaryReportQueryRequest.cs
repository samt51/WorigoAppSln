using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetTaskSummaryReport
{
    public class GetTaskSummaryReportQueryRequest : IRequest<ResponseDto<GetTaskSummaryReportQueryResponse>>
    {
        public int HotelId { get; set; }
    }
}
