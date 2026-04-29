using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ServiceRequestMessages.Queries.GetServiceRequestMessages
{
    public class GetServiceRequestMessagesQueryHandler : BaseHandler, IRequestHandler<GetServiceRequestMessagesQueryRequest, ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>>
    {
        public GetServiceRequestMessagesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetServiceRequestMessagesQueryResponse>>> Handle(GetServiceRequestMessagesQueryRequest request, CancellationToken cancellationToken)
        {
            var messages = await unitOfWork.GetReadRepository<ServiceRequestMessage>().GetAllAsync(
                x => x.ServiceRequestId == request.ServiceRequestId && !x.IsDeleted,
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
