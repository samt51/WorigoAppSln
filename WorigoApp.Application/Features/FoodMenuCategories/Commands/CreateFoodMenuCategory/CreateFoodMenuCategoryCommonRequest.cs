using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.FoodMenuCategories.Commands.CreateFoodMenuCategory
{
/// <summary>
/// CreateFoodMenuCategoryCommonRequest sınıfını temsil eder.
/// </summary>
public class CreateFoodMenuCategoryCommonRequest : IRequest<ResponseDto<CreateFoodMenuCategoryCommonResponse>>
    {
/// <summary>
/// CreateFoodMenuCategoryCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateFoodMenuCategoryCommonRequest(string name, int hotelid)
        {
            this.Name = name;
            this.HotelId = hotelid;
        }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; }
    }
}
