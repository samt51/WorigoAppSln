using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Transfers.Queries.GetTransferTracking
{
    public class GetTransferTrackingQueryRequest : IRequest<ResponseDto<TransferTracking>>
    {
        public int ServiceRequestId { get; set; }
        public string SessionToken { get; set; } = string.Empty;
    }
}
