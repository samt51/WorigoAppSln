namespace WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType
{
/// <summary>
/// CreateRoomTypeCommandResponse sınıfını temsil eder.
/// </summary>
public class CreateRoomTypeCommandResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
    }
}
