using System;
using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// SpaAppointment sınıfını temsil eder.
/// </summary>
public class SpaAppointment : EntityBase
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// ServiceName değerini alır veya ayarlar.
/// </summary>
public string ServiceName { get; set; } = string.Empty;
/// <summary>
/// TherapistName değerini alır veya ayarlar.
/// </summary>
public string TherapistName { get; set; } = string.Empty;
/// <summary>
/// AppointmentDate değerini alır veya ayarlar.
/// </summary>
public DateTime AppointmentDate { get; set; }
/// <summary>
/// TimeSlot değerini alır veya ayarlar.
/// </summary>
public string TimeSlot { get; set; } = string.Empty;
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// CurrencyCode değerini alır veya ayarlar.
/// </summary>
public string CurrencyCode { get; set; } = "TRY";
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = "Confirmed";
        
/// <summary>
/// GuestStay değerini alır veya ayarlar.
/// </summary>
public GuestStay GuestStay { get; set; } = null!;
    }
}
