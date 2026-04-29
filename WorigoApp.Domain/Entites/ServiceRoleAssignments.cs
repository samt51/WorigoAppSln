using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Bir servis tipinin hangi departman veya çalışan rolüne düşeceğini tanımlar.
    /// </summary>
    public class ServiceRoleAssignments : EntityBase
    {
        public ServiceRoleAssignments()
        {
        }

        public ServiceRoleAssignments(int id, int serviceId, int employeeTypeRoleId)
        {
            Id = id;
            ServiceId = serviceId;
            EmployeeTypeRoleId = employeeTypeRoleId;
        }

        /// <summary>
        /// İlgili servis kategorisinin enum karşılığıdır.
        /// </summary>
        public ServicesEnum ServicesEnumId { get; set; }

        /// <summary>
        /// Atama kuralının geçerli olduğu otel.
        /// </summary>
        public int? HotelId { get; set; }

        /// <summary>
        /// Atama kuralının ait olduğu departman.
        /// </summary>
        public int? DepartmentId { get; set; }

        public int ServiceId { get; set; }
        public int EmployeeTypeRoleId { get; set; }

        /// <summary>
        /// Kuralın birincil atama olup olmadığını belirtir.
        /// </summary>
        public bool IsPrimaryAssignment { get; set; } = true;

        /// <summary>
        /// Kural önceliği.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Servis için beklenen çözüm süresi dakikası.
        /// </summary>
        public int? SlaMinutes { get; set; }
    }
}
