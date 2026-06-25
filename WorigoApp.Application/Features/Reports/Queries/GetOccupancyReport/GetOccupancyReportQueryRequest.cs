using MediatR;
using System;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetOccupancyReport
{
/// <summary>
/// GetOccupancyReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetOccupancyReportQueryRequest : IRequest<ResponseDto<GetOccupancyReportQueryResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Date değerini alır veya ayarlar.
/// </summary>
public DateTime? Date { get; set; }
    }
}
