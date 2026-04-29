using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus
{
    public class UpdateServiceRequestStatusCommandRequest : IRequest<ResponseDto<UpdateServiceRequestStatusCommandResponse>>
    {
        public int ServiceRequestId { get; set; }
        public ServiceRequestStatusEnum NewStatus { get; set; }
        public int? AssignedEmployeeId { get; set; }
        public int? ChangedByUserId { get; set; }
        public string? Note { get; set; }
    }
}
