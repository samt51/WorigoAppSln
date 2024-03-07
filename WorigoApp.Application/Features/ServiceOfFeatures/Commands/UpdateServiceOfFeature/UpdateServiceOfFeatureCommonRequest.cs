using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceOfFeatures.Commands.UpdateServiceOfFeature
{
    public class UpdateServiceOfFeatureCommonRequest : IRequest<Response<UpdateServiceOfFeatureCommonResponse>>
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public UpdateServiceOfFeatureCommonRequest(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
