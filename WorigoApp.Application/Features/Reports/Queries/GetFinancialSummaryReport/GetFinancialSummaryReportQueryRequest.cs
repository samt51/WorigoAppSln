using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport
{
    public class GetFinancialSummaryReportQueryRequest : IRequest<ResponseDto<GetFinancialSummaryReportQueryResponse>>
    {
        public int HotelId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
