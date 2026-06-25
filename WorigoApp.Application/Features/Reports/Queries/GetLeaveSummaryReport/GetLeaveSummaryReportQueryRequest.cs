using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetLeaveSummaryReport
{
/// <summary>
/// GetLeaveSummaryReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetLeaveSummaryReportQueryRequest : IRequest<ResponseDto<IList<GetLeaveSummaryReportQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
