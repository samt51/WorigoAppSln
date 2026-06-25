using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetAttendanceSummaryReport
{
/// <summary>
/// GetAttendanceSummaryReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAttendanceSummaryReportQueryRequest : IRequest<ResponseDto<GetAttendanceSummaryReportQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
