using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Notifications.Commands.GenerateSuggestions
{
/// <summary>
/// GenerateSuggestionsCommandRequest sınıfını temsil eder.
/// </summary>
public class GenerateSuggestionsCommandRequest : IRequest<ResponseDto<GenerateSuggestionsResponse>>
    {
    }
}
