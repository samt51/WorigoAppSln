using WorigoApp.Domain.Common;
using System.Collections.Generic;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// RoomType sınıfını temsil eder.
/// </summary>
public class RoomType : EntityBase
    {
/// <summary>
/// RoomType sınıfının yeni bir örneğini başlatır.
/// </summary>
public RoomType()
        {
            Rooms = new List<Room>();
        }

/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; } = null!;
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string? Description { get; set; }
/// <summary>
/// Capacity değerini alır veya ayarlar.
/// </summary>
public int Capacity { get; set; } = 1;
/// <summary>
/// BasePrice değerini alır veya ayarlar.
/// </summary>
public decimal BasePrice { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }

/// <summary>
/// Rooms değerini alır veya ayarlar.
/// </summary>
public IList<Room> Rooms { get; set; }
    }
}
