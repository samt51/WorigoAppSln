using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.ToggleRoomTypeStatus
{
/// <summary>
/// ToggleRoomTypeStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class ToggleRoomTypeStatusCommandRequest : IRequest<ResponseDto<ToggleRoomTypeStatusCommandResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ToggleRoomTypeStatusCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public ToggleRoomTypeStatusCommandRequest(int id)
        {
            Id = id;
        }
    }
}
