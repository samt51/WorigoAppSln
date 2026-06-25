using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ConciergePlace sınıfını temsil eder.
/// </summary>
public class ConciergePlace : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// Category değerini alır veya ayarlar.
/// </summary>
public string Category { get; set; } = string.Empty;
/// <summary>
/// Address değerini alır veya ayarlar.
/// </summary>
public string? Address { get; set; }
/// <summary>
/// Latitude değerini alır veya ayarlar.
/// </summary>
public string? Latitude { get; set; }
/// <summary>
/// Longitude değerini alır veya ayarlar.
/// </summary>
public string? Longitude { get; set; }
/// <summary>
/// PhoneNumber değerini alır veya ayarlar.
/// </summary>
public string? PhoneNumber { get; set; }
/// <summary>
/// WebsiteUrl değerini alır veya ayarlar.
/// </summary>
public string? WebsiteUrl { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string? ImageUrl { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
    }
}
