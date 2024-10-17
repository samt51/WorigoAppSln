using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.RoomBasedTransactions.Commands.UpdatedCustomer
{
    public class UpdatedCustomerCommandRequest : IRequest<Response<UpdatedCustomerCommandResponse>>
    {
        public int Id { get; }
        public int RoomId { get; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public UpdatedCustomerCommandRequest(int id, int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            this.RoomId = roomId;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.Id = id;
        }
    }
}
