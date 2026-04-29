using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites.GServices
{
    /// <summary>
    /// Saðlýk ve Ýlk Yardým 
    /// </summary>
    public class HealthAndSafety : EntityBase
    {
        public int GuestStayId { get; set; }
        public HealthAndFirstHelpTypeEnum HealthAndFirstHelpTypeEnum { get; set; }
        public string Text { get; set; }
    }
}
