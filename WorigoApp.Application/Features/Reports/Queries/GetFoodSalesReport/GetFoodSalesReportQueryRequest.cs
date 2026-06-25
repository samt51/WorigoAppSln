using MediatR;
using System;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Reports.Queries.GetFoodSalesReport
{
/// <summary>
/// GetFoodSalesReportQueryRequest sınıfını temsil eder.
/// </summary>
public class GetFoodSalesReportQueryRequest : IRequest<ResponseDto<GetFoodSalesReportQueryResponse>>
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
