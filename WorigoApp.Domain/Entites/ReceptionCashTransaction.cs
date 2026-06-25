using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites;

/// <summary>
/// ReceptionCashTransaction sınıfını temsil eder.
/// </summary>
public class ReceptionCashTransaction : EntityBase
{
/// <summary>
/// ReceptionCashShiftId değerini alır veya ayarlar.
/// </summary>
public int ReceptionCashShiftId { get; set; }
/// <summary>
/// ReceptionCashShift değerini alır veya ayarlar.
/// </summary>
public ReceptionCashShift ReceptionCashShift { get; set; } = null!;
/// <summary>
/// Type değerini alır veya ayarlar.
/// </summary>
public string Type { get; set; } = "Income";
/// <summary>
/// Amount değerini alır veya ayarlar.
/// </summary>
public decimal Amount { get; set; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; } = string.Empty;
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int? GuestStayId { get; set; }
/// <summary>
/// PaymentMethod değerini alır veya ayarlar.
/// </summary>
public string PaymentMethod { get; set; } = "Cash";
}
