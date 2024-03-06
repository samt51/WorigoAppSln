using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ServiceOfValue : EntityBase
    {
        public ServiceOfValue()
        {

        }
        public ServiceOfValue(string value, int? serviceOfFeatureId, int? serviceId)
        {
            this.ServiceId = serviceId;
            this.Value = value;
            this.ServiceOfFeatureId = serviceOfFeatureId;
        }

        public string Value { get; set; }
        public int? ServiceOfFeatureId { get; set; }
        public ServiceOfFeature ServiceOfFeature { get; set; }
        public int? ServiceId { get; set; }
        public Service Service { get; set; }

    }
}
