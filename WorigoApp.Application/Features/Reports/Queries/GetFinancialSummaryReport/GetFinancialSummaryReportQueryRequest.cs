using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetFinancialSummaryReport
{
/// <summary>
/// GetFinancialSummaryReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetFinancialSummaryReportQueryRequest : IRequest<ResponseDto<GetFinancialSummaryReportQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// StartDate değerini alır veya ayarlar.
/// </summary>
public DateTime? StartDate { get; set; }
/// <summary>
/// EndDate değerini alır veya ayarlar.
/// </summary>
public DateTime? EndDate { get; set; }
    }
}
