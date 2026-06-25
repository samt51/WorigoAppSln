using WorigoApp.Application.Features.FoodTypes.Queries.GetAllFoodTypes;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRooms
{
/// <summary>
/// GetRoomsQueryResponse sınıfını temsil eder.
/// </summary>
public class GetRoomsQueryResponse
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
