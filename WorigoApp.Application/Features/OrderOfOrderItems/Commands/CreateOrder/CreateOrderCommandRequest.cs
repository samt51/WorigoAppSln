using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.OrderOfOrderItems.Dto;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<ResponseDto<CreateOrderCommandResponse>>
    {
        public int GuestStayId { get; set; }
        public OrderPaymentOptionEnum RequestedPaymentOption { get; set; } = OrderPaymentOptionEnum.RoomCharge;
        public IList<CreateOrderItems> CreateOrderItems { get; set; } = new List<CreateOrderItems>();

        public CreateOrderCommandRequest()
        {
        }

        public CreateOrderCommandRequest(int guestStayId, IList<CreateOrderItems> createOrderItems)
        {
            GuestStayId = guestStayId;
            CreateOrderItems = createOrderItems;
        }
    }
}
