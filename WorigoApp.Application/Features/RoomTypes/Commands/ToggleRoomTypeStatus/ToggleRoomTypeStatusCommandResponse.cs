namespace WorigoApp.Application.Features.RoomTypes.Commands.ToggleRoomTypeStatus
{
/// <summary>
/// ToggleRoomTypeStatusCommandResponse sınıfını temsil eder.
/// </summary>
public class ToggleRoomTypeStatusCommandResponse
    {
/// <summary>
/// Success değerini alır veya ayarlar.
/// </summary>
public bool Success { get; set; }
/// <summary>
/// NewStatus değerini alır veya ayarlar.
/// </summary>
public bool NewStatus { get; set; }
    }
}
