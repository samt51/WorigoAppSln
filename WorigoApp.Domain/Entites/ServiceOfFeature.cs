using WorigoApp.Domain.Common;

namespace WorigoApp.Domain.Entites
{
    public class ServiceOfFeature : EntityBase
    {
        public ServiceOfFeature()
        {
            
        }
        public ServiceOfFeature(string name, int serviceid)
        {
            this.Name = name;
            this.ServiceId = serviceid;
        }

        public string Name { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public IList<ServiceOfValue> ServiceOfValues { get; set; }
    }
}
