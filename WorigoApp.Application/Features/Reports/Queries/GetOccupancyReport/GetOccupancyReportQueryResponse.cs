namespace WorigoApp.Application.Features.Reports.Queries.GetOccupancyReport
{
/// <summary>
/// GetOccupancyReportQueryResponse sınıfını temsil eder.
/// </summary>
public class GetOccupancyReportQueryResponse
    {
/// <summary>
/// TotalRoomCount değerini alır veya ayarlar.
/// </summary>
public int TotalRoomCount { get; set; }
/// <summary>
/// OccupiedRoomCount değerini alır veya ayarlar.
/// </summary>
public int OccupiedRoomCount { get; set; }
/// <summary>
/// OccupancyRate değerini alır veya ayarlar.
/// </summary>
public decimal OccupancyRate { get; set; }
/// <summary>
/// CleanRoomCount değerini alır veya ayarlar.
/// </summary>
public int CleanRoomCount { get; set; }
/// <summary>
/// DirtyRoomCount değerini alır veya ayarlar.
/// </summary>
public int DirtyRoomCount { get; set; }
/// <summary>
/// OutOfOrderRoomCount değerini alır veya ayarlar.
/// </summary>
public int OutOfOrderRoomCount { get; set; }
/// <summary>
/// ExpectedArrivalsCount değerini alır veya ayarlar.
/// </summary>
public int ExpectedArrivalsCount { get; set; }
/// <summary>
/// ExpectedDeparturesCount değerini alır veya ayarlar.
/// </summary>
public int ExpectedDeparturesCount { get; set; }
/// <summary>
/// VIPGuestsCount değerini alır veya ayarlar.
/// </summary>
public int VIPGuestsCount { get; set; }
    }
}
