using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage;
using WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.ServiceRequests
{
    [Authorize]
    public class ServiceRequestMessagesController : BaseController
    {
        private readonly IMediator _mediator;

        public ServiceRequestMessagesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Servis talebi icin yeni chat mesaji olusturur ve hedef dile cevirir.")]
        public async Task<ResponseDto<CreateServiceRequestMessageCommandResponse>> Create(CreateServiceRequestMessageCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("{serviceRequestId}")]
        [SwaggerDescriptionAttirbute("Servis talebine ait chat mesajlarini listeler.")]
        public async Task<ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>> GetByServiceRequest(int serviceRequestId)
        {
            return await _mediator.Send(new GetServiceRequestMessagesQueryRequest
            {
                ServiceRequestId = serviceRequestId
            });
        }
    }
}
