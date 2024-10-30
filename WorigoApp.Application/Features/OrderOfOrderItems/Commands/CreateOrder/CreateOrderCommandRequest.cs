using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.OrderOfOrderItems.Dto;

namespace WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder
{
    public class CreateOrderCommandRequest : IRequest<Response<CreateOrderCommandResponse>>
    {
        public int RoomBasedTransactionId { get; set; }
        public IList<CreateOrderItems> CreateOrderItems { get; set; }

        public CreateOrderCommandRequest(int roomBasedTransactionId, IList<CreateOrderItems> createOrderItems)
        {
            RoomBasedTransactionId = roomBasedTransactionId;
            CreateOrderItems = createOrderItems;
        }
    }
}
