using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages
{
/// <summary>
/// GetServiceRequestMessagesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetServiceRequestMessagesQueryRequest : IRequest<ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>>
    {
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int ServiceRequestId { get; set; }
    }
}
