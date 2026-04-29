using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestStays.Dtos;

namespace WorigoApp.Application.Features.GuestStays.Commands.CreateCustomer
{
    public class CreateCustomerCommandRequest : IRequest<ResponseDto<CreateCustomerCommandResponse>>
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
