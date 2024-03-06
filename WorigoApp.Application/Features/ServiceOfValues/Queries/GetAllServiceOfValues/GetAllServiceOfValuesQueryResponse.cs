using WorigoApp.Application.Features.ServiceOfFeatures.Queries.GetAllServiceOfFeature;
using WorigoApp.Application.Features.Services.Queries.GetAllServices;

namespace WorigoApp.Application.Features.ServiceOfValues.Queries.GetAllServiceOfValues
{
    public class GetAllServiceOfValuesQueryResponse
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int? ServiceOfFeatureId { get; set; }
        public GetAllServiceOfFeatureQueryResponse ServiceOfFeature { get; set; }
        public int? ServiceId { get; set; }
        public GetAllServicesQueryResponse Service { get; set; }
    }
}
