using System.Collections.Generic;

namespace WorigoApp.Application.Features.Reports.Queries.GetFoodSalesReport
{
/// <summary>
/// GetFoodSalesReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetFoodSalesReportQueryResponse
    {
/// <summary>
/// TotalOrdersCount değerini alır veya ayarlar.
/// </summary>
public int TotalOrdersCount { get; set; }
/// <summary>
/// TotalRevenue değerini alır veya ayarlar.
/// </summary>
public decimal TotalRevenue { get; set; }
/// <summary>
/// AverageOrderValue değerini alır veya ayarlar.
/// </summary>
public decimal AverageOrderValue { get; set; }
/// <summary>
/// TopSellingItems değerini alır veya ayarlar.
/// </summary>
public List<TopSellingItemDto> TopSellingItems { get; set; } = new List<TopSellingItemDto>();
/// <summary>
/// HourlyOrderDistribution değerini alır veya ayarlar.
/// </summary>
public List<HourlyOrderDto> HourlyOrderDistribution { get; set; } = new List<HourlyOrderDto>();
    }

/// <summary>
/// TopSellingItemDto sınıfını temsil eder.
/// </summary>
public class TopSellingItemDto
    {
/// <summary>
/// ItemName değerini alır veya ayarlar.
/// </summary>
public string ItemName { get; set; } = string.Empty;
/// <summary>
/// Quantity değerini alır veya ayarlar.
/// </summary>
public int Quantity { get; set; }
/// <summary>
/// Revenue değerini alır veya ayarlar.
/// </summary>
public decimal Revenue { get; set; }
    }

/// <summary>
/// HourlyOrderDto sınıfını temsil eder.
/// </summary>
public class HourlyOrderDto
    {
/// <summary>
/// Hour değerini alır veya ayarlar.
/// </summary>
public int Hour { get; set; }
/// <summary>
/// OrderCount değerini alır veya ayarlar.
/// </summary>
public int OrderCount { get; set; }
    }
}
