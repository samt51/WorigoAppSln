using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Sağlık ve İlk Yardım 
    /// </summary>
    public class HealthAndSafety : EntityBase
    {
        public int RoomBasedTransactionId { get; set; }
        public HealthAndFirstHelpTypeEnum HealthAndFirstHelpTypeEnum { get; set; }
        public string Text { get; set; }
    }
}
