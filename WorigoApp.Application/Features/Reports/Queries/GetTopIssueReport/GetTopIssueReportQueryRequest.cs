using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetTopIssueReport
{
/// <summary>
/// GetTopIssueReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetTopIssueReportQueryRequest : IRequest<ResponseDto<IList<GetTopIssueReportQueryResponse>>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Take değerini alır veya ayarlar.
/// </summary>
public int Take { get; set; } = 10;
    }
}
