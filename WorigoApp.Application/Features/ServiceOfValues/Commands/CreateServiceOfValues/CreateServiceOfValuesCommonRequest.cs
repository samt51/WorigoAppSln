using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceOfValues.Commands.CreateServiceOfValues
{
    public class UpdateServiceOfValuesCommonRequest : IRequest<Response<UpdateServiceOfValuesCommonResponse>>
    {
        public string Value { get; set; }
        public int? ServiceOfFeatureId { get; set; }
        public int? ServiceId { get; set; }
    }
}
