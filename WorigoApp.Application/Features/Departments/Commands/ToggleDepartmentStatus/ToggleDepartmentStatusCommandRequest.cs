using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Commands.ToggleDepartmentStatus
{
    public class ToggleDepartmentStatusCommandRequest : IRequest<ResponseDto<ToggleDepartmentStatusCommandResponse>>
    {
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }
    }
}
