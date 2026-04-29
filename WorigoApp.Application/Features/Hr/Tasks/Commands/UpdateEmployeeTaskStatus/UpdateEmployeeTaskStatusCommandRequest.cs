using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.UpdateEmployeeTaskStatus
{
    public class UpdateEmployeeTaskStatusCommandRequest : IRequest<ResponseDto<UpdateEmployeeTaskStatusCommandResponse>>
    {
        public int EmployeeTaskId { get; set; }
        public EmployeeTaskStatusEnum Status { get; set; }
        public string? CompletionNote { get; set; }
    }
}
