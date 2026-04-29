using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.Translation;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Commands.CreateServiceRequestMessage
{
    public class CreateServiceRequestMessageCommandHandler : BaseHandler, IRequestHandler<CreateServiceRequestMessageCommandRequest, ResponseDto<CreateServiceRequestMessageCommandResponse>>
    {
        private readonly IChatTranslationService _translationService;

        public CreateServiceRequestMessageCommandHandler(IChatTranslationService translationService, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            _translationService = translationService;
        }

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

            var message = new ServiceRequestMessage
            {
                ServiceRequestId = request.ServiceRequestId,
                SenderUserId = request.SenderUserId,
                SenderType = request.SenderType,
                OriginalLanguageCode = request.OriginalLanguageCode,
                OriginalText = request.OriginalText,
                MessageType = request.MessageType,
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

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            var createdMessage = await unitOfWork.GetWriteRepository<ServiceRequestMessage>().AddAsync(message);
            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateServiceRequestMessageCommandResponse>().Success(new CreateServiceRequestMessageCommandResponse
            {
                Id = createdMessage.Id,
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
