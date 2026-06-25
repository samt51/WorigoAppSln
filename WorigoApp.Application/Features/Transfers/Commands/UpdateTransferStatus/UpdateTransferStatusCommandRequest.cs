using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Transfers.Commands.UpdateTransferStatus
{
/// <summary>
/// UpdateTransferStatusCommandRequest sınıfını temsil eder.
/// </summary>
public class UpdateTransferStatusCommandRequest : IRequest<ResponseDto<UpdateTransferStatusResponse>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
    }
}
