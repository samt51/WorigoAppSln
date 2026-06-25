using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Transfers.Queries.GetTransferTracking
{
/// <summary>
/// GetTransferTrackingQueryRequest sınıfını temsil eder.
/// </summary>
public class GetTransferTrackingQueryRequest : IRequest<ResponseDto<TransferTracking>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
