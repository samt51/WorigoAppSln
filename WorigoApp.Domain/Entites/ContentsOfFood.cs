using WorigoApp.Domain.Common;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Domain.Entites
{
/// <summary>
/// ContentsOfFood sınıfını temsil eder.
/// </summary>
public class ContentsOfFood : EntityBase
    {
/// <summary>
/// ContentsOfFood sınıfının yeni bir örneğini başlatır.
/// </summary>
public ContentsOfFood() { }
/// <summary>
/// ContentsOfFood sınıfının yeni bir örneğini başlatır.
/// </summary>
public ContentsOfFood(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// FoodContentsOfFoods değerini alır veya ayarlar.
/// </summary>
public ICollection<FoodContentsOfFood> FoodContentsOfFoods { get; set; }
    }
}
