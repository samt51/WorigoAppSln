using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.Translation;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
/// <summary>
/// CreateServiceRequestMessageCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestMessageCommandHandler : BaseHandler, IRequestHandler<CreateServiceRequestMessageCommandRequest, ResponseDto<CreateServiceRequestMessageCommandResponse>>
    {
        private readonly IChatTranslationService _translationService;
/// <summary>
/// CreateServiceRequestMessageCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateServiceRequestMessageCommandHandler(IChatTranslationService translationService, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            _translationService = translationService;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateServiceRequestMessageCommandResponse>> Handle(CreateServiceRequestMessageCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceRequest = await unitOfWork.GetReadRepository<ServiceRequest>()
                .GetAsync(x => x.Id == request.ServiceRequestId && !x.IsDeleted, enableTracking: true);

            if (request.SenderUserId.HasValue)
            {
                await unitOfWork.GetReadRepository<Users>()
                    .GetAsync(x => x.Id == request.SenderUserId.Value && !x.IsDeleted);
            }

            var targetLanguageCode = await ResolveTargetLanguageCodeAsync(serviceRequest, request.SenderType);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            // Ensure Conversation exists
            if (!serviceRequest.ConversationId.HasValue)
            {
                var newConversation = new Conversation
                {
                    HotelId = serviceRequest.HotelId,
                    GuestStayId = serviceRequest.GuestStayId,
                    CustomerId = serviceRequest.CustomerId,
                    Subject = serviceRequest.Title,
                    Status = ConversationStatusEnum.Open,
                    ConversationType = ConversationTypeEnum.General,
                    LanguageCode = serviceRequest.LanguageCode,
                    StartedAt = DateTime.UtcNow
                };
                var createdConversation = await unitOfWork.GetWriteRepository<Conversation>().AddAsync(newConversation);
                await unitOfWork.SaveAsync(cancellationToken);

                serviceRequest.ConversationId = createdConversation.Id;
                serviceRequest.IsChatStarted = true;
                await unitOfWork.GetWriteRepository<ServiceRequest>().UpdateAsync(serviceRequest);
                await unitOfWork.SaveAsync(cancellationToken);
            }

            Enum.TryParse<ConversationMessageTypeEnum>(request.MessageType, true, out var typeEnum);

            var message = new ConversationMessage
            {
                ConversationId = serviceRequest.ConversationId.Value,
                SenderUserId = request.SenderUserId,
                SenderCustomerId = request.SenderType == MessageSenderTypeEnum.Customer ? serviceRequest.CustomerId : null,
                SenderType = request.SenderType,
                OriginalLanguageCode = request.OriginalLanguageCode,
                OriginalText = request.OriginalText,
                MessageType = typeEnum == default ? ConversationMessageTypeEnum.Text : typeEnum,
                SentAt = DateTime.UtcNow
            };

            try
            {
                var translation = await _translationService.TranslateAsync(
                    request.OriginalText,
                    request.OriginalLanguageCode,
                    targetLanguageCode,
                    cancellationToken);

                message.TranslatedLanguageCode = translation.TargetLanguageCode;
                message.TranslatedText = translation.TranslatedText;
                message.NormalizedText = translation.NormalizedText;
                message.TranslationProvider = translation.Provider;
                message.TranslationModel = translation.Model;
                message.TranslationStatus = string.Equals(request.OriginalLanguageCode, targetLanguageCode, StringComparison.OrdinalIgnoreCase)
                    ? "Skipped"
                    : "Success";
            }
            catch
            {
                message.TranslatedLanguageCode = targetLanguageCode;
                message.TranslatedText = request.OriginalText;
                message.NormalizedText = request.OriginalText.Trim();
                message.TranslationProvider = "OpenAI";
                message.TranslationStatus = "Failed";
            }

            var createdMessage = await unitOfWork.GetWriteRepository<ConversationMessage>().AddAsync(message);
            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateServiceRequestMessageCommandResponse>().Success(new CreateServiceRequestMessageCommandResponse
            {
                Id = createdMessage.Id,
                ServiceRequestId = serviceRequest.Id,
                SenderUserId = createdMessage.SenderUserId,
                SenderType = createdMessage.SenderType.ToString(),
                OriginalLanguageCode = createdMessage.OriginalLanguageCode,
                OriginalText = createdMessage.OriginalText,
                TranslatedLanguageCode = createdMessage.TranslatedLanguageCode,
                TranslatedText = createdMessage.TranslatedText,
                TranslationStatus = createdMessage.TranslationStatus,
                SentAt = createdMessage.SentAt
            });
        }

        private async Task<string> ResolveTargetLanguageCodeAsync(ServiceRequest serviceRequest, MessageSenderTypeEnum senderType)
        {
            if (senderType == MessageSenderTypeEnum.Customer)
            {
                if (serviceRequest.AssignedEmployeeId.HasValue)
                {
                    var employee = await unitOfWork.GetReadRepository<Employee>()
                        .GetAsync(x => x.Id == serviceRequest.AssignedEmployeeId.Value && !x.IsDeleted);

                    if (!string.IsNullOrWhiteSpace(employee.LanguageCodes))
                    {
                        return employee.LanguageCodes.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).FirstOrDefault() ?? "tr-TR";
                    }
                }

                return "tr-TR";
            }

            if (serviceRequest.CustomerId.HasValue)
            {
                var customer = await unitOfWork.GetReadRepository<Customer>()
                    .GetAsync(x => x.Id == serviceRequest.CustomerId.Value && !x.IsDeleted);

                return string.IsNullOrWhiteSpace(customer.PreferredLanguageCode) ? serviceRequest.LanguageCode : customer.PreferredLanguageCode;
            }

            return serviceRequest.LanguageCode;
        }
    }
}
