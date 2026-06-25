using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType
{
/// <summary>
/// CreateRoomTypeCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateRoomTypeCommandRequest : IRequest<ResponseDto<CreateRoomTypeCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
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
public int Capacity { get; set; }
/// <summary>
/// BasePrice değerini alır veya ayarlar.
/// </summary>
public decimal BasePrice { get; set; }
/// <summary>
/// DisplayOrder değerini alır veya ayarlar.
/// </summary>
public int DisplayOrder { get; set; }
/// <summary>
/// IsActive değerini alır veya ayarlar.
/// </summary>
public bool IsActive { get; set; }
    }
}
