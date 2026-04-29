using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages
{
    public class GetServiceRequestMessagesQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>>
    {
        public int ServiceRequestId { get; set; }
    }
}
