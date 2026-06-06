using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Api.Hubs;
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
        private readonly IHubContext<HotelOperationsHub> _hubContext;

        public ServiceRequestMessagesController(IMediator mediator, IHubContext<HotelOperationsHub> hubContext) : base(mediator)
        {
            _mediator = mediator;
            _hubContext = hubContext;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Servis talebi icin yeni chat mesaji olusturur ve hedef dile cevirir.")]
        public async Task<ResponseDto<CreateServiceRequestMessageCommandResponse>> Create(CreateServiceRequestMessageCommandRequest request)
        {
            var response = await _mediator.Send(request);

            if (response.IsSuccess && response.Data is not null)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.ServiceRequest(response.Data.ServiceRequestId))
                    .SendAsync("ServiceRequestMessageCreated", response.Data);
            }

            return response;
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
