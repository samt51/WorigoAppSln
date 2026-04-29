using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetStockSummaryReport
{
    public class GetStockSummaryReportQueryRequest : IRequest<ResponseDto<GetStockSummaryReportQueryResponse>>
    {
        public int HotelId { get; set; }
    }
}
