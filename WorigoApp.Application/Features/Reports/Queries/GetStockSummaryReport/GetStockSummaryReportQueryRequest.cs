using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetStockSummaryReport
{
/// <summary>
/// GetStockSummaryReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetStockSummaryReportQueryRequest : IRequest<ResponseDto<GetStockSummaryReportQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
