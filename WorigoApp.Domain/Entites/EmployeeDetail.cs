using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class EmployeeDetail : EntityBase
    {
        public EmployeeDetail()
        {

        }
        public EmployeeDetail(int id, int employeeId, DateTime dateOfBirth, int? floorNo, string phoneNumber, bool gender, DateTime startDateOfWork,
          DateTime? exitDateOfWork, DateTime? LastOnlineTime, bool onlineOrOfflineNow)
        {
            this.Id = id;
            this.EmployeeId = employeeId;
            this.DateOfBirth = dateOfBirth;
            this.FloorNo = floorNo;
            this.PhoneNumber = phoneNumber;
            this.Gender = gender;
            this.StartDateOfWork = startDateOfWork;
            this.ExitDateOfWork = exitDateOfWork;
            this.LastOnlineTime = LastOnlineTime;
            this.OnlineOrOfflineNow = onlineOrOfflineNow;
        }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
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
