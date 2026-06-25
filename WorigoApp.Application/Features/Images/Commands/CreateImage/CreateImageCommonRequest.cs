using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Commands.CreateImage
{
/// <summary>
/// UpdateImageCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateImageCommonRequest :IRequest<ResponseDto<CreateImageCommonResponse>>
    {
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string ImageUrl { get; set; }
/// <summary>
/// ImageCategoryId değerini alır veya ayarlar.
/// </summary>
public int ImageCategoryId { get; set; }
    }
}
