using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    /// <summary>
    /// Personellerin hangi saat aralığında çalıştığını tanımlayan vardiya bilgisini tutar.
    /// </summary>
    public class Shift : EntityBase
    {
        /// <summary>
        /// Vardiyanın görünen adı.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Vardiyanın başlangıç saati.
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Vardiyanın bitiş saati.
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Vardiyanın ait olduğu otel.
        /// </summary>
        public int? HotelId { get; set; }

        public Hotel? Hotel { get; set; }

        /// <summary>
        /// Vardiya açıklaması.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Vardiyanın gece vardiyası olup olmadığını belirtir.
        /// </summary>
        public bool IsNightShift { get; set; }

        public IList<Employee> Employees { get; set; } = new List<Employee>();
        public IList<AttendanceRecord> AttendanceRecords { get; set; } = new List<AttendanceRecord>();
    }
}
