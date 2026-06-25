using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Rooms.Commands.UpdateRoomAvailabilityStatus
{
/// <summary>
/// UpdateRoomAvailabilityStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateRoomAvailabilityStatusCommandRequest : IRequest<ResponseDto<bool>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
    }
}
