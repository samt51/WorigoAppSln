using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Dto;

namespace WorigoApp.Application.Features.Foods.Commands.CreateFood
{
/// <summary>
/// CreateFoodCommonRequest sınıfını temsil eder.
/// </summary>
public class CreateFoodCommonRequest : IRequest<ResponseDto<CreateFoodCommonResponse>>
    {

/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
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
/// contentOfFoodRequestAndResponseDto değerini alır veya ayarlar.
/// </summary>
public List<ContentOfFoodRequestAndResponseDto> contentOfFoodRequestAndResponseDto { get; set; }
    }
}
