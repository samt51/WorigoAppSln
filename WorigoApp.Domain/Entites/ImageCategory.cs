using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ImageCategory sınıfını temsil eder.
/// </summary>
public class ImageCategory : EntityBase
    {
/// <summary>
/// ImageCategory sınıfının yeni bir örneğini başlatır.
/// </summary>
public ImageCategory()
        {
                
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
/// Images değerini alır veya ayarlar.
/// </summary>
public IList<Image> Images { get; set; }
/// <summary>
/// ImageCategory sınıfının yeni bir örneğini başlatır.
/// </summary>
public ImageCategory(string name, int hotelId)
        {
            this.Name = name;
            this.HotelId = hotelId;
        }
    }
}
