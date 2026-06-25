using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Helpers.ChatFlow;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Conversations.Commands.StartConversationFlow
{
/// <summary>
/// StartConversationFlowCommandHandler sınıfını temsil eder.
/// </summary>
public class StartConversationFlowCommandHandler : BaseHandler, IRequestHandler<StartConversationFlowCommandRequest, ResponseDto<StartConversationFlowCommandResponse>>
    {
/// <summary>
/// StartConversationFlowCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public StartConversationFlowCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
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
                        !x.IsDeleted,
                        include: query => query
                            .Include(x => x.ServiceCategory)
                            .Include(x => x.Fields)
                                .ThenInclude(x => x.Options));
            }

            IList<ServiceDefinition> categoryDefinitions = new List<ServiceDefinition>();
            if (definition is null && category is not null)
            {
                categoryDefinitions = await unitOfWork.GetReadRepository<ServiceDefinition>()
                    .GetAllAsync(x =>
                        x.ServiceCategoryId == category.Id &&
                        x.HotelId == guestStay.HotelId &&
                        x.IsVisibleToGuest &&
                        x.IsActive &&
                        !x.IsDeleted,
                        orderBy: query => query.OrderBy(x => x.DisplayOrder).ThenBy(x => x.Name));
            }

            var translations = await unitOfWork.GetReadRepository<Translation>()
                .GetAllAsync(x =>
                    x.LanguageCode == request.LanguageCode &&
                    x.IsActive &&
                    !x.IsDeleted);

            var flowType = string.IsNullOrWhiteSpace(request.FlowType)
                ? definition?.ServiceType.ToString() ?? category?.LegacyServiceType?.ToString() ?? "General"
                : request.FlowType;
            var categoryName = category is not null
                ? ResolveTranslatedValue(translations, nameof(ServiceCategory), category.Id, "Name", category.Name)
                : definition?.ServiceCategory is not null
                    ? ResolveTranslatedValue(translations, nameof(ServiceCategory), definition.ServiceCategory.Id, "Name", definition.ServiceCategory.Name)
                    : null;
            var flowUiType = ChatFlowTemplateFactory.ResolveUiType(flowType, categoryName);
            var openingMessage = string.IsNullOrWhiteSpace(request.OpeningMessage)
                ? ResolveOpeningMessage(definition, flowUiType, flowType, categoryName, translations)
                : request.OpeningMessage;
            var openingPayloadJson = string.IsNullOrWhiteSpace(request.OpeningPayloadJson)
                ? BuildDbDrivenOpeningPayloadJson(flowUiType, flowType, categoryName, openingMessage, definition, categoryDefinitions, translations)
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

        private static string BuildDbDrivenOpeningPayloadJson(
            ServiceFlowUiTypeEnum flowUiType,
            string flowType,
            string? categoryName,
            string openingMessage,
            ServiceDefinition? definition,
            IList<ServiceDefinition> categoryDefinitions,
            IList<Translation> translations)
        {
            if (definition is not null && definition.Fields.Any(x => x.IsActive && !x.IsDeleted))
            {
                var payload = new
                {
                    uiType = flowUiType.ToString(),
                    title = openingMessage,
                    serviceDefinitionId = definition.Id,
                    serviceType = definition.ServiceType.ToString(),
                    supportsFreeText = definition.SupportsFreeText,
                    requiresAppointment = definition.RequiresAppointment,
                    fields = definition.Fields
                        .Where(x => x.IsActive && !x.IsDeleted)
                        .OrderBy(x => x.DisplayOrder)
                        .Select(x => new
                        {
                            id = x.Id,
                            key = x.FieldKey,
                            label = ResolveTranslatedValue(translations, nameof(ServiceDefinitionField), x.Id, "Label", x.Label),
                            placeholder = string.IsNullOrWhiteSpace(x.Placeholder)
                                ? x.Placeholder
                                : ResolveTranslatedValue(translations, nameof(ServiceDefinitionField), x.Id, "Placeholder", x.Placeholder),
                            type = x.FieldType.ToString(),
                            isRequired = x.IsRequired,
                            displayOrder = x.DisplayOrder,
                            options = x.Options.Any()
                                ? x.Options
                                    .Where(option => option.IsActive && !option.IsDeleted)
                                    .OrderBy(option => option.DisplayOrder)
                                    .Select(option => new
                                    {
                                        id = option.Id,
                                        value = option.Value,
                                        label = ResolveTranslatedValue(translations, nameof(ServiceDefinitionFieldOption), option.Id, "Label", option.Label)
                                    })
                                : ParseOptions(x.OptionsJson),
                            validationRegex = x.ValidationRegex,
                            defaultValue = x.DefaultValue
                        })
                };

                return JsonSerializer.Serialize(payload);
            }

            if (categoryDefinitions.Any())
            {
                return ChatFlowTemplateFactory.BuildOpeningPayloadJson(
                    flowUiType,
                    flowType,
                    categoryDefinitions.Select(x => (ResolveTranslatedValue(translations, nameof(ServiceDefinition), x.Id, "Name", x.Name), x.Id.ToString())),
                    categoryName,
                    openingMessage);
            }

            return ChatFlowTemplateFactory.BuildOpeningPayloadJson(flowUiType, flowType, categoryName: categoryName, openingMessage: openingMessage);
        }

        private static object? ParseOptions(string? optionsJson)
        {
            if (string.IsNullOrWhiteSpace(optionsJson))
            {
                return null;
            }

            try
            {
                return JsonSerializer.Deserialize<JsonElement>(optionsJson);
            }
            catch (JsonException)
            {
                return optionsJson;
            }
        }

        private static string ResolveOpeningMessage(
            ServiceDefinition? definition,
            ServiceFlowUiTypeEnum flowUiType,
            string flowType,
            string? categoryName,
            IList<Translation> translations)
        {
            return !string.IsNullOrWhiteSpace(definition?.OpeningMessage)
                ? ResolveTranslatedValue(translations, nameof(ServiceDefinition), definition.Id, "OpeningMessage", definition.OpeningMessage!)
                : ChatFlowTemplateFactory.ResolveOpeningMessage(flowUiType, flowType, categoryName);
        }

        private static string ResolveTranslatedValue(
            IList<Translation> translations,
            string tableName,
            int recordId,
            string fieldName,
            string fallbackValue)
        {
            return translations.FirstOrDefault(x =>
                       x.TableName == tableName &&
                       x.RecordId == recordId &&
                       x.FieldName == fieldName)
                   ?.TranslationValue
                   ?? fallbackValue;
        }
    }
}
