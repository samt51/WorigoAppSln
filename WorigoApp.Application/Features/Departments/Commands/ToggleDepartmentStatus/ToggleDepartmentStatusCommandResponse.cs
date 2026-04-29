namespace WorigoApp.Application.Features.Departments.Commands.ToggleDepartmentStatus
{
    public class ToggleDepartmentStatusCommandResponse
    {
        public int DepartmentId { get; set; }
        public bool IsActive { get; set; }
    }
}
