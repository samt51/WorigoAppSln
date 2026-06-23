using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Notifications.Commands.GenerateSuggestions;

namespace WorigoApp.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("system")]
    public class SystemOperationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHubContext<HotelOperationsHub> _hubContext;

        public SystemOperationsController(IMediator mediator, IHubContext<HotelOperationsHub> hubContext)
        {
            _mediator = mediator;
            _hubContext = hubContext;
        }

        [HttpPost("guest-engagement/generate-suggestions")]
        public async Task<ResponseDto<int>> GenerateSuggestions(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GenerateSuggestionsCommandRequest(), cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                // Send SignalR notification to each guest stay group for new suggestions
                foreach (var notif in response.Data.NotificationsToBroadcast)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(notif.GuestStayId))
                        .SendAsync("NotificationReceived", new
                        {
                            Title = notif.Title,
                            Message = notif.Message,
                            NotificationType = notif.NotificationType,
                            SentAt = notif.SentAt
                        }, cancellationToken);
                }

                return new ResponseDto<int>().Success(response.Data.GeneratedCount);
            }

            return new ResponseDto<int>().Fail(response.Errors ?? new List<string> { "Öneriler üretilemedi." }, response.StatusCode);
        }
    }
}
