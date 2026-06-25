using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Commands.CreateImageCategory
{
/// <summary>
/// UpdateImageCategoryCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateImageCategoryCommonRequest :IRequest<ResponseDto<UpdateImageCategoryCommonResponse>>
    {
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
    }
}
