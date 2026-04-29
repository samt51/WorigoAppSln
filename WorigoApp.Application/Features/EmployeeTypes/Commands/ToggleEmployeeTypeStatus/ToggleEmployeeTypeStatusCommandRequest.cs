using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.ToggleEmployeeTypeStatus
{
    public class ToggleEmployeeTypeStatusCommandRequest : IRequest<ResponseDto<ToggleEmployeeTypeStatusCommandResponse>>
    {
        public int EmployeeTypeId { get; set; }
        public bool IsActive { get; set; }
    }
}
