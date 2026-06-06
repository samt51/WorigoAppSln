using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class Currency : EntityBase
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string CultureCode { get; set; } = string.Empty;
        public int DecimalDigits { get; set; } = 2;
        public bool IsBaseCurrency { get; set; }
        public bool IsSupported { get; set; } = true;
        public int SortOrder { get; set; }
    }
}
