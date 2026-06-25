using WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes;

namespace WorigoApp.Application.Features.Rooms.Queries.GetByIdRoom
{
/// <summary>
/// GetByIdRoomQueryResponse sınıfını temsil eder.
/// </summary>
public class GetByIdRoomQueryResponse
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
public int RoomFoodTypeId { get; set; }
/// <summary>
/// RoomFoodTypeResponse değerini alır veya ayarlar.
/// </summary>
public GetAllFoodTypesQueryResponse RoomFoodTypeResponse { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
