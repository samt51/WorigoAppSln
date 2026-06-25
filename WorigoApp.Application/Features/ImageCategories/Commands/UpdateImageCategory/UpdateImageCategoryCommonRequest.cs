using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Commands.UpdateImageCategory
{
/// <summary>
/// UpdateImageCategoryCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateImageCategoryCommonRequest :IRequest<ResponseDto<UpdateImageCategoryCommonResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; }
    }
}
