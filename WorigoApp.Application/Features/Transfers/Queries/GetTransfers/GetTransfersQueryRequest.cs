using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Transfers.Queries.GetTransfers
{
/// <summary>
/// GetTransfersQueryRequest sınıfını temsil eder.
/// </summary>
public class GetTransfersQueryRequest : IRequest<ResponseDto<IList<TransferTracking>>>
    {
/// <summary>
/// SessionToken değerini alır veya ayarlar.
/// </summary>
public string SessionToken { get; set; } = string.Empty;
    }
}
