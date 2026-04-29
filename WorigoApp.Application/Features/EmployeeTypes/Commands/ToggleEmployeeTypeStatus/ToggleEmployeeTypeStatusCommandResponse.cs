namespace WorigoApp.Application.Features.EmployeeTypes.Commands.ToggleEmployeeTypeStatus
{
    public class ToggleEmployeeTypeStatusCommandResponse
    {
        public int EmployeeTypeId { get; set; }
        public bool IsActive { get; set; }
    }
}
