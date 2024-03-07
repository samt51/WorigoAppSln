using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Commands.CreateServiceOfFeature
{
    public class UpdateServiceOfFeatureCommonRequest : IRequest<Response<CreateServiceOfFeatureCommonResponse>>
    {
        public string Name { get; set; }
        public int ServiceId { get; set; }
        public UpdateServiceOfFeatureCommonRequest(string name, int serviceId)
        {
            this.Name = name;
            this.ServiceId = serviceId;
        }
    }
}
