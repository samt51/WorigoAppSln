using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;

namespace WorigoApp.Application.Features.Foods.Commands.UpdateFood
{
/// <summary>
/// UpdateFoodCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateFoodCommonRequest : IRequest<ResponseDto<UpdateFoodCommonResponse>>
    {
/// <summary>
/// UpdateFoodCommonRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateFoodCommonRequest(int id, string name, decimal price, string description, int foodMenuCategoryId, List<ContentOfFoodRequestAndResponseDto> requestAndResponseDto)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.FoodMenuCategoryId = foodMenuCategoryId;
            this.contentOfFoodRequestAndResponseDto = requestAndResponseDto;
        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; }
/// <summary>
/// Price değerini alır veya ayarlar.
/// </summary>
public decimal Price { get; }
/// <summary>
/// Description değerini alır veya ayarlar.
/// </summary>
public string Description { get; }
/// <summary>
/// FoodMenuCategoryId değerini alır veya ayarlar.
/// </summary>
public int FoodMenuCategoryId { get; }

/// <summary>
/// contentOfFoodRequestAndResponseDto değerini alır veya ayarlar.
/// </summary>
public List<ContentOfFoodRequestAndResponseDto> contentOfFoodRequestAndResponseDto { get; }
    }
}
