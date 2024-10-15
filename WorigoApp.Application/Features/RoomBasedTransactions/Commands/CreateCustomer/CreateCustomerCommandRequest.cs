using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.RoomBasedTransactions.Dtos;

namespace WorigoApp.Application.Features.RoomBasedTransactions.Commands.CreateCustomer
{
    public class CreateCustomerCommandRequest : IRequest<Response<CreateCustomerCommandResponse>>
    {
        public int HotelId { get; }
        public int RoomId { get; }
        public CustomerRequestDto CustomerRequestDto { get; set; }
        public DateTime CheckInDate { get; }
        public DateTime CheckOutDate { get; }
        public string VerificationCode { get; }

        public CreateCustomerCommandRequest(int hotelId, int roomId, DateTime checkInDate, DateTime checkOutDate, string verificationCode)
        {
            this.RoomId = roomId;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.VerificationCode = verificationCode;
            this.HotelId = hotelId;
        }
    }
}
