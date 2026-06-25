using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus
{
/// <summary>
/// UpdateServiceRequestStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateServiceRequestStatusCommandRequest : IRequest<ResponseDto<UpdateServiceRequestStatusCommandResponse>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// NewStatus değerini alır veya ayarlar.
/// </summary>
public ServiceRequestStatusEnum NewStatus { get; set; }
/// <summary>
/// AssignedEmployeeId değerini alır veya ayarlar.
/// </summary>
public int? AssignedEmployeeId { get; set; }
/// <summary>
/// ChangedByUserId değerini alır veya ayarlar.
/// </summary>
public int? ChangedByUserId { get; set; }
/// <summary>
/// Note değerini alır veya ayarlar.
/// </summary>
public string? Note { get; set; }
    }
}
