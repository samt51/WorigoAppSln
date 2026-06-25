using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.GuestStays.Commands.UpdatedCustomer
{
/// <summary>
/// UpdatedCustomerCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdatedCustomerCommandRequest : IRequest<ResponseDto<UpdatedCustomerCommandResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// RoomId değerini alır veya ayarlar.
/// </summary>
public int RoomId { get; }
/// <summary>
/// CheckInDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckInDate { get; }
/// <summary>
/// CheckOutDate değerini alır veya ayarlar.
/// </summary>
public DateTime CheckOutDate { get; }
/// <summary>
/// UpdatedCustomerCommandRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdatedCustomerCommandRequest(int id, int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            this.RoomId = roomId;
            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.Id = id;
        }
    }
}
