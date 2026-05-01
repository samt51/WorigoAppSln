using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Conversations.Commands.AddConversationMessage
{
    public class AddConversationMessageCommandHandler : BaseHandler, IRequestHandler<AddConversationMessageCommandRequest, ResponseDto<AddConversationMessageCommandResponse>>
    {
        public AddConversationMessageCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<AddConversationMessageCommandResponse>> Handle(AddConversationMessageCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Conversation>()
                .GetAsync(x => x.Id == request.ConversationId && x.IsActive && !x.IsDeleted);

            var now = DateTime.UtcNow;
            var message = await unitOfWork.GetWriteRepository<ConversationMessage>().AddAsync(new ConversationMessage
            {
                ConversationId = request.ConversationId,
                SenderUserId = request.SenderUserId,
                SenderCustomerId = request.SenderCustomerId,
                SenderType = request.SenderType,
                OriginalLanguageCode = request.OriginalLanguageCode,
                OriginalText = request.OriginalText,
                MessageType = request.MessageType,
                PayloadJson = request.PayloadJson,
                SentAt = now,
                TranslationStatus = "Pending"
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<AddConversationMessageCommandResponse>().Success(new AddConversationMessageCommandResponse
            {
                Id = message.Id,
                ConversationId = message.ConversationId,
                MessageType = message.MessageType,
                SentAt = message.SentAt
            });
        }
    }
}
