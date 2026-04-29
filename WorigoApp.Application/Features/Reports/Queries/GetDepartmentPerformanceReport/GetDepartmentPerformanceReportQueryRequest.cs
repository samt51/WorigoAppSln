using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetDepartmentPerformanceReport
{
    public class GetDepartmentPerformanceReportQueryRequest : IRequest<ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>>
    {
        public int HotelId { get; set; }
    }
}
