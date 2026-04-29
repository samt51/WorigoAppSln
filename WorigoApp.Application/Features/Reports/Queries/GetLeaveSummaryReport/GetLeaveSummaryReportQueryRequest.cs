using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport
{
    public class GetLeaveSummaryReportQueryRequest : IRequest<ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>>
    {
        public int HotelId { get; set; }
    }
}
