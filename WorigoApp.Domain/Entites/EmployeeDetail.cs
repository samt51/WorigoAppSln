using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personelin iletişim, özlük ve profil detaylarını tutar.
    /// </summary>
    public class EmployeeDetail : EntityBase
    {
        public EmployeeDetail()
        {
        }

        public EmployeeDetail(int id, int employeeId, DateTime dateOfBirth, string phoneNumber, bool gender, DateTime startDateOfWork,
            DateTime? exitDateOfWork, DateTime? lastOnlineTime)
        {
            Id = id;
            EmployeeId = employeeId;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Gender = gender;
            StartDateOfWork = startDateOfWork;
            ExitDateOfWork = exitDateOfWork;
            LastOnlineTime = lastOnlineTime;
        }

        public EmployeeDetail(int id, int employeeId, DateTime dateOfBirth, int? floorNo, string phoneNumber, bool gender,
            DateTime startDateOfWork, DateTime? exitDateOfWork, DateTime? lastOnlineTime, bool onlineOrOfflineNow)
            : this(id, employeeId, dateOfBirth, phoneNumber, gender, startDateOfWork, exitDateOfWork, lastOnlineTime)
        {
            FloorNo = floorNo;
            OnlineOrOfflineNow = onlineOrOfflineNow;
        }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        /// <summary>
        /// Doğum tarihi.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Telefon numarası.
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Mevcut akışlarla uyumlu basit cinsiyet alanı.
        /// </summary>
        public bool Gender { get; set; }

        /// <summary>
        /// İşe başlama tarihi.
        /// </summary>
        public DateTime StartDateOfWork { get; set; }

        /// <summary>
        /// İşten ayrılma tarihi.
        /// </summary>
        public DateTime? ExitDateOfWork { get; set; }

        /// <summary>
        /// Personelin son çevrim içi olduğu an.
        /// </summary>
        public DateTime? LastOnlineTime { get; set; }

        /// <summary>
        /// Personelin ağırlıklı çalıştığı kat bilgisi.
        /// </summary>
        public int? FloorNo { get; set; }

        /// <summary>
        /// Personelin o anda çevrim içi görünüp görünmediği.
        /// </summary>
        public bool OnlineOrOfflineNow { get; set; }

        /// <summary>
        /// Acil durumda aranacak kişi adı.
        /// </summary>
        public string? EmergencyContactName { get; set; }

        /// <summary>
        /// Acil durumda aranacak kişi telefonu.
        /// </summary>
        public string? EmergencyContactPhone { get; set; }

        /// <summary>
        /// Kimlik veya pasaport numarası gibi resmi numara bilgisi.
        /// </summary>
        public string? NationalId { get; set; }

        /// <summary>
        /// Personelin ikamet adresi.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Personelin profil dili.
        /// </summary>
        public string? ProfileLanguage { get; set; }
    }
}
