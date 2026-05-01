using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Conversations.Commands.UpdateConversationFlow
{
    public class UpdateConversationFlowCommandHandler : BaseHandler, IRequestHandler<UpdateConversationFlowCommandRequest, ResponseDto<UpdateConversationFlowCommandResponse>>
    {
        public UpdateConversationFlowCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateConversationFlowCommandResponse>> Handle(UpdateConversationFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var flowSession = await unitOfWork.GetReadRepository<ConversationFlowSession>()
                .GetAsync(x => x.Id == request.FlowSessionId && x.IsActive && !x.IsDeleted);

            flowSession.ServiceCategoryId = request.ServiceCategoryId ?? flowSession.ServiceCategoryId;
            flowSession.ServiceDefinitionId = request.ServiceDefinitionId ?? flowSession.ServiceDefinitionId;
            flowSession.CurrentStep = request.CurrentStep;
            flowSession.StateJson = string.IsNullOrWhiteSpace(request.StateJson) ? "{}" : request.StateJson;
            flowSession.IsCompleted = request.IsCompleted;
            flowSession.CompletedAt = request.IsCompleted ? DateTime.UtcNow : null;

            await unitOfWork.GetWriteRepository<ConversationFlowSession>().UpdateAsync(flowSession);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<UpdateConversationFlowCommandResponse>().Success(new UpdateConversationFlowCommandResponse
            {
                FlowSessionId = flowSession.Id,
                CurrentStep = flowSession.CurrentStep,
                IsCompleted = flowSession.IsCompleted
            });
        }
    }
}
