using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetEmployeePerformanceReport
{
/// <summary>
/// GetEmployeePerformanceReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetEmployeePerformanceReportQueryRequest : IRequest<ResponseDto<IList<GetEmployeePerformanceReportQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
