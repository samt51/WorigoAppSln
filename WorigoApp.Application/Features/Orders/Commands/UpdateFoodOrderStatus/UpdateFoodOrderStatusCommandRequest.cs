using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Orders.Commands.UpdateFoodOrderStatus
{
/// <summary>
/// UpdateFoodOrderStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateFoodOrderStatusCommandRequest : IRequest<ResponseDto<UpdateFoodOrderStatusResponse>>
    {
/// <summary>
/// OrderId değerini alır veya ayarlar.
/// </summary>
public int OrderId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
    }
}
