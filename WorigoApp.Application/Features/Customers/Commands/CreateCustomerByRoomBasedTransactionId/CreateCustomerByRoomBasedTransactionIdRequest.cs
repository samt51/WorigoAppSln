using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Customers.Commands.CreateCustomerByRoomBasedTransactionId
{
    public class CreateCustomerByRoomBasedTransactionIdRequest : IRequest<Response<CreateCustomerByRoomBasedTransactionIdResponse>>
    {
        public int RoomBasedTransactionId { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool Gender { get; set; }
        public CreateCustomerByRoomBasedTransactionIdRequest(int roomBasedTransactionId, string name, string surName, bool gender)
        {
            this.RoomBasedTransactionId = roomBasedTransactionId;
            this.Name = name;
            this.SurName = surName;
            this.Gender = gender;
        }
    }
}
