using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Rooms.Commands.UpdateRoom
{
/// <summary>
/// UpdateRoomCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateRoomCommonRequest : IRequest<ResponseDto<UpdateRoomCommonResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// RoomTypeId değerini alır veya ayarlar.
/// </summary>
public int RoomTypeId { get; set; }
/// <summary>
/// RoomFoodTypeId değerini alır veya ayarlar.
/// </summary>
public RoomFoodTypeEnum RoomFoodTypeId { get; set; }
/// <summary>
/// UpdateRoomCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateRoomCommonRequest(int id, string name, int roomTypeId, RoomFoodTypeEnum roomFoodTypeId)
        {
            this.Id = id;
            this.Name = name;
            this.RoomTypeId = roomTypeId;
            this.RoomFoodTypeId = roomFoodTypeId;
       
        }
    }
}
