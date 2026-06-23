using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Transfers.Queries.GetTransfers
{
    public class GetTransfersQueryRequest : IRequest<ResponseDto<IList<TransferTracking>>>
    {
        public string SessionToken { get; set; } = string.Empty;
    }
}
