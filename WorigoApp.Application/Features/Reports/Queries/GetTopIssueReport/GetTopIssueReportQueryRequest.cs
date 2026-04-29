using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetTopIssueReport
{
    public class GetTopIssueReportQueryRequest : IRequest<ResponseDto<IList<GetTopIssueReportQueryResponse>>>
    {
        public int HotelId { get; set; }
        public int Take { get; set; } = 10;
    }
}
