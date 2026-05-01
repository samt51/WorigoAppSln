using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Conversations.Commands.AddConversationMessage;
using WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow;
using WorigoApp.Application.Features.Conversations.Commands.UpdateConversationFlow;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Conversations
{
    [Authorize]
    public class ConversationsController : BaseController
    {
        private readonly IMediator _mediator;

        public ConversationsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Kart veya hizmet seciminden sonra structured chat flow baslatir.")]
        public async Task<ResponseDto<StartConversationFlowCommandResponse>> StartFlow(StartConversationFlowCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Conversation icine text, quick reply, option list, form, product card veya confirmation mesaji ekler.")]
        public async Task<ResponseDto<AddConversationMessageCommandResponse>> AddMessage(AddConversationMessageCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Chat flow state bilgisini gunceller.")]
        public async Task<ResponseDto<UpdateConversationFlowCommandResponse>> UpdateFlow(UpdateConversationFlowCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
