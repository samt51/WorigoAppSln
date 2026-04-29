using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Orders
{
    [Authorize]
    public class OrdersController : BaseController
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Misafirin servis veya urun siparisini kaydeder.")]
        public async Task<ResponseDto<CreateOrderCommandResponse>> Create(CreateOrderCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
