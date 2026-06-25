using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetDepartmentPerformanceReport
{
/// <summary>
/// GetDepartmentPerformanceReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetDepartmentPerformanceReportQueryRequest : IRequest<ResponseDto<IList<GetDepartmentPerformanceReportQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
