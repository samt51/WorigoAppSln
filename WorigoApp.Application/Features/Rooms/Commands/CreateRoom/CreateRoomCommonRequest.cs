using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Rooms.Commands.CreateRoom
{
/// <summary>
/// UpdateRoomCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateRoomCommonRequest : IRequest<ResponseDto<UpdateRoomCommonResponse>>
    {
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
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// UpdateRoomCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateRoomCommonRequest(string name, int roomTypeId, RoomFoodTypeEnum roomFoodTypeId, int hotelId)
        {
            this.Name = name;
            this.RoomTypeId = roomTypeId;
            this.RoomFoodTypeId = roomFoodTypeId;
            this.HotelId = hotelId;
        }
    }
}
