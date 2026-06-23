using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Transfers.Commands.UpdateTransferStatus
{
    public class UpdateTransferStatusCommandRequest : IRequest<ResponseDto<UpdateTransferStatusResponse>>
    {
        public int ServiceRequestId { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
