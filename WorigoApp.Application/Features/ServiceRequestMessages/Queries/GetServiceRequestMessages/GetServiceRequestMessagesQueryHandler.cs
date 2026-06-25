using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages
{
/// <summary>
/// GetServiceRequestMessagesQueryHandler sınıfını temsil eder.
/// </summary>
public class GetServiceRequestMessagesQueryHandler : BaseHandler, IRequestHandler<GetServiceRequestMessagesQueryRequest, ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>>
    {
/// <summary>
/// GetServiceRequestMessagesQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetServiceRequestMessagesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>> Handle(GetServiceRequestMessagesQueryRequest request, CancellationToken cancellationToken)
        {
            var serviceRequest = await unitOfWork.GetReadRepository<ServiceRequest>()
                .GetAsync(x => x.Id == request.ServiceRequestId && !x.IsDeleted);

            if (serviceRequest == null || !serviceRequest.ConversationId.HasValue)
            {
                return new ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>().Success(new List<GetServiceRequestMessagesQueryResponse>());
            }

            var messages = await unitOfWork.GetReadRepository<ConversationMessage>().GetAllAsync(
                x => x.ConversationId == serviceRequest.ConversationId.Value && !x.IsDeleted,
                orderBy: x => x.OrderBy(y => y.SentAt));

            var response = messages.Select(x => new GetServiceRequestMessagesQueryResponse
            {
                Id = x.Id,
                SenderType = x.SenderType,
                SenderUserId = x.SenderUserId,
                OriginalLanguageCode = x.OriginalLanguageCode,
                OriginalText = x.OriginalText,
                TranslatedLanguageCode = x.TranslatedLanguageCode,
                TranslatedText = x.TranslatedText,
                TranslationStatus = x.TranslationStatus,
                SentAt = x.SentAt
            }).ToList();

            return new ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>().Success(response);
        }
    }
}
