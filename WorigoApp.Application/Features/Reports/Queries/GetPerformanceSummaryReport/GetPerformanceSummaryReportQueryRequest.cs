using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetPerformanceSummaryReport
{
/// <summary>
/// GetPerformanceSummaryReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetPerformanceSummaryReportQueryRequest : IRequest<ResponseDto<GetPerformanceSummaryReportQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
