using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetEmployeePerformanceReport
{
    public class GetEmployeePerformanceReportQueryRequest : IRequest<ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>>
    {
        public int HotelId { get; set; }
    }
}
