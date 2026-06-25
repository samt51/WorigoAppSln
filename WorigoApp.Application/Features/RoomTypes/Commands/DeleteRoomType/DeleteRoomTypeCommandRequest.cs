using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomTypes.Commands.DeleteRoomType
{
/// <summary>
/// DeleteRoomTypeCommandRequest sınıfını temsil eder.
/// </summary>
public class DeleteRoomTypeCommandRequest : IRequest<ResponseDto<DeleteRoomTypeCommandResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// DeleteRoomTypeCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public DeleteRoomTypeCommandRequest(int id)
        {
            Id = id;
        }
    }
}
