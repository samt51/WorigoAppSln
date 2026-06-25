using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Queries.GetRoomAvailabilityStatus
{
/// <summary>
/// GetRoomAvailabilityStatusQueryRequest sınıfını temsil eder.
/// </summary>
public class GetRoomAvailabilityStatusQueryRequest : IRequest<ResponseDto<RoomAvailabilityStatusResponse>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
