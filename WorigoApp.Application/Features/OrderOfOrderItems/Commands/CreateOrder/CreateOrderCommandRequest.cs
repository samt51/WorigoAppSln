using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.OrderOfOrderItems.Dto;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
/// <summary>
/// CreateOrderCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateOrderCommandRequest : IRequest<ResponseDto<CreateOrderCommandResponse>>
    {
/// <summary>
/// GuestStayId değerini alır veya ayarlar.
/// </summary>
public int GuestStayId { get; set; }
/// <summary>
/// RequestedPaymentOption değerini alır veya ayarlar.
/// </summary>
public OrderPaymentOptionEnum RequestedPaymentOption { get; set; } = OrderPaymentOptionEnum.RoomCharge;
/// <summary>
/// CreateOrderItems değerini alır veya ayarlar.
/// </summary>
public IList<CreateOrderItems> CreateOrderItems { get; set; } = new List<CreateOrderItems>();
/// <summary>
/// CreateOrderCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateOrderCommandRequest()
        {
        }
/// <summary>
/// CreateOrderCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateOrderCommandRequest(int guestStayId, IList<CreateOrderItems> createOrderItems)
        {
            GuestStayId = guestStayId;
            CreateOrderItems = createOrderItems;
        }
    }
}
