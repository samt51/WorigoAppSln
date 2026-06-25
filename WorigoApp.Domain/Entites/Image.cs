using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Image sınıfını temsil eder.
/// </summary>
public class Image : EntityBase
    {
/// <summary>
/// Image sınıfının yeni bir örneğini başlatır.
/// </summary>
public Image()
        {

        }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string ImageUrl { get; set; }
/// <summary>
/// ImageCategoryId değerini alır veya ayarlar.
/// </summary>
public int ImageCategoryId { get; set; }
/// <summary>
/// ImageCategory değerini alır veya ayarlar.
/// </summary>
public ImageCategory ImageCategory { get; set; }
/// <summary>
/// OrderItemId değerini alır veya ayarlar.
/// </summary>
public int? OrderItemId { get; set; }
/// <summary>
/// OrderItem değerini alır veya ayarlar.
/// </summary>
public OrderItem OrderItem { get; set; }
/// <summary>
/// FoodId değerini alır veya ayarlar.
/// </summary>
public int? FoodId { get; set; }
/// <summary>
/// Food değerini alır veya ayarlar.
/// </summary>
public Food Food { get; set; }
/// <summary>
/// Image sınıfının yeni bir örneğini başlatır.
/// </summary>
public Image(string imageUrl, int imageCategoryId)
        {
            this.ImageUrl = imageUrl;
            this.ImageCategoryId = imageCategoryId;
        }
    }
}
