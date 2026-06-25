using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Commands.UpdateImage
{
/// <summary>
/// UpdateImageCommonRequest sınıfını temsil eder.
/// </summary>
public class UpdateImageCommonRequest :IRequest<ResponseDto<UpdateImageCommonResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// ImageUrl değerini alır veya ayarlar.
/// </summary>
public string ImageUrl { get; set; }
    }
}
