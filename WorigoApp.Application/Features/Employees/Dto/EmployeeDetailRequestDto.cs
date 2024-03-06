namespace WorigoApp.Application.Features.Employees.Dto
{
    public class EmployeeDetailRequestDto
    {
        public DateTime DateOfBirth { get; set; }
        public int? FloorNo { get; set; }
        public string PhoneNumber { get; set; }
        public bool Gender { get; set; }
        public DateTime StartDateOfWork { get; set; }
        public DateTime? ExitDateOfWork { get; set; }
        public DateTime? LastOnlineTime { get; set; }
        public bool OnlineOrOfflineNow { get; set; }
    }
}
