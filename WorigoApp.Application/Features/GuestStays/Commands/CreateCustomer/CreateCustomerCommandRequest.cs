using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestStays.Dtos;

namespace WorigoApp.Application.Features.GuestStays.Commands.CreateCustomer
{
/// <summary>
/// CreateCustomerCommandRequest sınıfını temsil eder.
/// </summary>
public class CreateCustomerCommandRequest : IRequest<ResponseDto<CreateCustomerCommandResponse>>
    {
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; }
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int RoomId { get; }
/// <summary>
/// CustomerRequestDto değerini alır veya ayarlar.
/// </summary>
public CustomerRequestDto CustomerRequestDto { get; set; }
/// <summary>
/// CheckInDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckInDate { get; }
/// <summary>
/// CheckOutDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckOutDate { get; }
/// <summary>
/// VerificationCode değerini alır veya ayarlar.
/// </summary>
public string VerificationCode { get; }
/// <summary>
/// CreateCustomerCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
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
