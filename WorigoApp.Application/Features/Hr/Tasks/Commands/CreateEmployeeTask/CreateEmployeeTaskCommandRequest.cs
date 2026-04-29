using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Hr.Tasks.Commands.CreateEmployeeTask
{
    public class CreateEmployeeTaskCommandRequest : IRequest<ResponseDto<CreateEmployeeTaskCommandResponse>>
    {
        public int HotelId { get; set; }
        public int AssignedEmployeeId { get; set; }
        public int AssignedByEmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? RelatedServiceRequestId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public EmployeeTaskPriorityEnum Priority { get; set; } = EmployeeTaskPriorityEnum.Normal;
        public DateTime? DueAt { get; set; }
    }
}
