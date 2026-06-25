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
    /// <summary>
    /// ConversationsController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class ConversationsController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// ConversationsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ConversationsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Kart veya hizmet seciminden sonra structured chat flow baslatir.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Kart veya hizmet seciminden sonra structured chat flow baslatir.")]
        public async Task<ResponseDto<StartConversationFlowCommandResponse>> StartFlow(StartConversationFlowCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Conversation icine text, quick reply, option list, form, product card veya confirmation mesaji ekler.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Conversation icine text, quick reply, option list, form, product card veya confirmation mesaji ekler.")]
        public async Task<ResponseDto<AddConversationMessageCommandResponse>> AddMessage(AddConversationMessageCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Chat flow state bilgisini gunceller.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Chat flow state bilgisini gunceller.")]
        public async Task<ResponseDto<UpdateConversationFlowCommandResponse>> UpdateFlow(UpdateConversationFlowCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
