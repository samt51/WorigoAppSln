using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceOfValues.Commands.UpdateServiceOfValues
{
    public class UpdateServiceOfValuesCommonRequest : IRequest<Response<UpdateServiceOfValuesCommonResponse>>
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int? ServiceOfFeatureId { get; set; }
        public int? ServiceId { get; set; }
    }
}
