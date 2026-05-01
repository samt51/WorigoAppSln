using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Helpers.ChatFlow;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow
{
    public class StartConversationFlowCommandHandler : BaseHandler, IRequestHandler<StartConversationFlowCommandRequest, ResponseDto<StartConversationFlowCommandResponse>>
    {
        public StartConversationFlowCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<StartConversationFlowCommandResponse>> Handle(StartConversationFlowCommandRequest request, CancellationToken cancellationToken)
        {
            var guestStay = await unitOfWork.GetReadRepository<GuestStay>()
                .GetAsync(x => x.Id == request.GuestStayId && x.IsActive && !x.IsDeleted);

            if (request.CustomerId.HasValue)
            {
                await unitOfWork.GetReadRepository<Customer>()
                    .GetAsync(x => x.Id == request.CustomerId.Value && x.GuestStayId == request.GuestStayId && !x.IsDeleted);
            }

            ServiceCategory? category = null;
            if (request.ServiceCategoryId.HasValue)
            {
                category = await unitOfWork.GetReadRepository<ServiceCategory>()
                    .GetAsync(x =>
                        x.Id == request.ServiceCategoryId.Value &&
                        x.HotelId == guestStay.HotelId &&
                        x.IsActive &&
                        !x.IsDeleted);
            }

            ServiceDefinition? definition = null;
            if (request.ServiceDefinitionId.HasValue)
            {
                definition = await unitOfWork.GetReadRepository<ServiceDefinition>()
                    .GetAsync(x =>
                        x.Id == request.ServiceDefinitionId.Value &&
                        x.HotelId == guestStay.HotelId &&
                        x.IsActive &&
                        !x.IsDeleted);
            }

            var flowType = string.IsNullOrWhiteSpace(request.FlowType)
                ? definition?.ServiceType.ToString() ?? category?.LegacyServiceType?.ToString() ?? "General"
                : request.FlowType;
            var categoryName = category?.Name ?? definition?.ServiceCategory?.Name;
            var flowUiType = ChatFlowTemplateFactory.ResolveUiType(flowType, categoryName);
            var openingMessage = string.IsNullOrWhiteSpace(request.OpeningMessage)
                ? ChatFlowTemplateFactory.ResolveOpeningMessage(flowUiType, flowType, categoryName)
                : request.OpeningMessage;
            var openingPayloadJson = string.IsNullOrWhiteSpace(request.OpeningPayloadJson)
                ? ChatFlowTemplateFactory.BuildOpeningPayloadJson(flowUiType, flowType, categoryName: categoryName)
                : request.OpeningPayloadJson;
            var openingMessageType = string.IsNullOrWhiteSpace(request.OpeningPayloadJson) && string.IsNullOrWhiteSpace(request.OpeningMessage)
                ? ChatFlowTemplateFactory.ResolveOpeningMessageType(flowUiType)
                : request.OpeningMessageType;

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var conversation = await unitOfWork.GetWriteRepository<Conversation>().AddAsync(new Conversation
            {
                HotelId = guestStay.HotelId,
                GuestStayId = guestStay.Id,
                CustomerId = request.CustomerId,
                Subject = request.Subject ?? definition?.Name ?? category?.Name ?? flowType,
                ConversationType = ConversationTypeEnum.ServiceRequest,
                LanguageCode = request.LanguageCode,
                StartedAt = DateTime.UtcNow
            });

            await unitOfWork.SaveAsync(cancellationToken);

            var flowSession = await unitOfWork.GetWriteRepository<ConversationFlowSession>().AddAsync(new ConversationFlowSession
            {
                ConversationId = conversation.Id,
                ServiceCategoryId = request.ServiceCategoryId,
                ServiceDefinitionId = request.ServiceDefinitionId,
                FlowType = flowType,
                CurrentStep = request.CurrentStep,
                StateJson = string.IsNullOrWhiteSpace(request.StateJson) ? "{}" : request.StateJson,
                StartedAt = DateTime.UtcNow
            });

            ConversationMessage? openingConversationMessage = null;
            if (!string.IsNullOrWhiteSpace(openingMessage) || !string.IsNullOrWhiteSpace(openingPayloadJson))
            {
                openingConversationMessage = await unitOfWork.GetWriteRepository<ConversationMessage>().AddAsync(new ConversationMessage
                {
                    ConversationId = conversation.Id,
                    SenderType = MessageSenderTypeEnum.System,
                    OriginalLanguageCode = request.LanguageCode,
                    OriginalText = openingMessage,
                    MessageType = openingMessageType,
                    PayloadJson = openingPayloadJson,
                    SentAt = DateTime.UtcNow,
                    TranslationStatus = "Skipped"
                });
            }

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<StartConversationFlowCommandResponse>().Success(new StartConversationFlowCommandResponse
            {
                ConversationId = conversation.Id,
                FlowSessionId = flowSession.Id,
                ServiceCategoryId = flowSession.ServiceCategoryId,
                ServiceDefinitionId = flowSession.ServiceDefinitionId,
                FlowType = flowSession.FlowType,
                CurrentStep = flowSession.CurrentStep,
                OpeningMessageId = openingConversationMessage?.Id,
                OpeningMessage = openingMessage,
                OpeningPayloadJson = openingPayloadJson
            });
        }
    }
}
