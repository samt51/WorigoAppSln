using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// Food sınıfını temsil eder.
/// </summary>
public class Food : EntityBase
    {
/// <summary>
/// Food sınıfının yeni bir örneğini başlatır.
/// </summary>
public Food()
        {

        }
/// <summary>
/// Food sınıfının yeni bir örneğini başlatır.
/// </summary>
public Food(int id, string name, decimal price, int priceStatusId, string description, int foodMenuCategoryId)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.PriceStatusId = priceStatusId;
            this.Description = description;
            this.FoodMenuCategoryId = foodMenuCategoryId;
        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// PriceStatusId değerini alır veya ayarlar.
/// </summary>
public int PriceStatusId { get; set; }
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; set; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; set; }
/// <summary>
/// FoodMenuCategoryId değerini alır veya ayarlar.
/// </summary>
public int FoodMenuCategoryId { get; set; }
/// <summary>
/// FoodMenuCategory değerini alır veya ayarlar.
/// </summary>
public FoodMenuCategory FoodMenuCategory { get; set; }
/// <summary>
/// FoodContentsOfFoods değerini alır veya ayarlar.
/// </summary>
public ICollection<FoodContentsOfFood> FoodContentsOfFoods { get; set; }
/// <summary>
/// Images değerini alır veya ayarlar.
/// </summary>
public IList<Image> Images { get; set; }
/// <summary>
/// ServiceRequestRatings değerini alır veya ayarlar.
/// </summary>
public IList<ServiceRequestRating> ServiceRequestRatings { get; set; }
/// <summary>
/// FoodAllergens değerini alır veya ayarlar.
/// </summary>
public ICollection<FoodAllergens> FoodAllergens { get; set; }
/// <summary>
/// FoodDietaryRestrictions değerini alır veya ayarlar.
/// </summary>
public ICollection<FoodDietaryRestrictions> FoodDietaryRestrictions { get; set; }
/// <summary>
/// NutritionalInfo değerini alır veya ayarlar.
/// </summary>
public NutritionalInfo NutritionalInfo { get; set; }
/// <summary>
/// DiscountPrice değerini alır veya ayarlar.
/// </summary>
public decimal? DiscountPrice { get; set; }  // İndirimli fiyat
/// <summary>
/// IsOnPromotion değerini alır veya ayarlar.
/// </summary>
public bool IsOnPromotion { get; set; }  // Promosyonda mı?
/// <summary>
/// IsAvailable değerini alır veya ayarlar.
/// </summary>
public bool IsAvailable { get; set; }  // Yemek mevcut mu?
        /// <summary>
        /// HAZIRLANMA SÜRESİ
        /// </summary>
        public TimeOnly PREPARATIONTIME { get; set; }
    }
}
