using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetTaskSummaryReport
{
/// <summary>
/// GetTaskSummaryReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetTaskSummaryReportQueryRequest : IRequest<ResponseDto<GetTaskSummaryReportQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
