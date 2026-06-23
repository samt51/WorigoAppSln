using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Notifications.Commands.GenerateSuggestions
{
    public class GenerateSuggestionsCommandRequest : IRequest<ResponseDto<GenerateSuggestionsResponse>>
    {
    }
}
