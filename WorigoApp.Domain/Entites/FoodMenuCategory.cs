using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// FoodMenuCategory sınıfını temsil eder.
/// </summary>
public class FoodMenuCategory : EntityBase
    {
/// <summary>
/// FoodMenuCategory sınıfının yeni bir örneğini başlatır.
/// </summary>
public FoodMenuCategory()
        {
            
        }
/// <summary>
/// FoodMenuCategory sınıfının yeni bir örneğini başlatır.
/// </summary>
public FoodMenuCategory(int id,string name, int hotelId)
        {
            this.Id = id;
            this.Name = name;
            this.HotelId = hotelId;
        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// Hotel değerini alır veya ayarlar.
/// </summary>
public Hotel Hotel { get; set; }
/// <summary>
/// Foods değerini alır veya ayarlar.
/// </summary>
public IList<Food> Foods { get; set; }
    }
}
