using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ReceptionAuditLog sınıfını temsil eder.
/// </summary>
public class ReceptionAuditLog : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// UserId değerini alır veya ayarlar.
/// </summary>
public int UserId { get; set; }
/// <summary>
/// Action değerini alır veya ayarlar.
/// </summary>
public string Action { get; set; } = string.Empty;
/// <summary>
/// EntityType değerini alır veya ayarlar.
/// </summary>
public string EntityType { get; set; } = string.Empty;
/// <summary>
/// EntityId değerini alır veya ayarlar.
/// </summary>
public int? EntityId { get; set; }
/// <summary>
/// Details değerini alır veya ayarlar.
/// </summary>
public string? Details { get; set; }
    }
}
