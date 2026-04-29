using WorigoApp.Domain.Common;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Domain.Entites
{
    public class ServiceCategory : EntityBase
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; } = null!;

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? IconUrl { get; set; }
        public int DisplayOrder { get; set; }

        public ServicesEnum? LegacyServiceType { get; set; }

        public IList<ServiceDefinition> ServiceDefinitions { get; set; } = new List<ServiceDefinition>();
    }
}
