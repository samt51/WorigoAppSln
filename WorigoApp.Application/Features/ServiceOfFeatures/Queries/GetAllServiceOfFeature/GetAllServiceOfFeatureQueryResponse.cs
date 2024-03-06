using WorigoApp.Application.Features.Services.Queries.GetAllServices;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Queries.GetAllServiceOfFeature
{
    public class GetAllServiceOfFeatureQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public GetAllServicesQueryResponse Service { get; set; }
        public IList<ServiceOfValue> ServiceOfValues { get; set; }
    }
}
