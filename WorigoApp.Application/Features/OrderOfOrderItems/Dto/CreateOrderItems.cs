using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Dto
{
/// <summary>
/// CreateOrderItems sınıfını temsil eder.
/// </summary>
public class CreateOrderItems
    {
/// <summary>
/// ServicesEnumId değerini alır veya ayarlar.
/// </summary>
public ServicesEnum ServicesEnumId { get; set; }
/// <summary>
/// ServiceItemId değerini alır veya ayarlar.
/// </summary>
public int ServiceItemId { get; set; }
/// <summary>
/// Quantity değerini alır veya ayarlar.
/// </summary>
public int Quantity { get; set; }
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// PriceStatusId değerini alır veya ayarlar.
/// </summary>
public int PriceStatusId { get; set; }
/// <summary>
/// AppointmentDate değerini alır veya ayarlar.
/// </summary>
public DateTime? AppointmentDate { get; set; }
/// <summary>
/// AppointmentLastDate değerini alır veya ayarlar.
/// </summary>
public DateTime? AppointmentLastDate { get; set; }
/// <summary>
/// Text değerini alır veya ayarlar.
/// </summary>
public string? Text { get; set; }
/// <summary>
/// ItemName değerini alır veya ayarlar.
/// </summary>
public string? ItemName { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string? CurrencyCode { get; set; }
    }
}
