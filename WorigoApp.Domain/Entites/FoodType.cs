using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// FoodType sınıfını temsil eder.
/// </summary>
public class FoodType : EntityBase
    {
/// <summary>
/// FoodType sınıfının yeni bir örneğini başlatır.
/// </summary>
public FoodType()
        {
            
        }
/// <summary>
/// RoomFoodTypeEnum değerini alır veya ayarlar.
/// </summary>
public RoomFoodTypeEnum RoomFoodTypeEnum { get; set; }
/// <summary>
/// Rooms değerini alır veya ayarlar.
/// </summary>
public IList<Room> Rooms { get; set;}
/// <summary>
/// FoodType sınıfının yeni bir örneğini başlatır.
/// </summary>
public FoodType(RoomFoodTypeEnum roomFoodTypeEnum)
        {
            this.RoomFoodTypeEnum = roomFoodTypeEnum;
        }
    }
}
