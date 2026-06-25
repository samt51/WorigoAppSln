using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.OrderOfOrderItems.Commands.CreateOrder;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Orders
{
    /// <summary>
    /// OrdersController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class OrdersController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// OrdersController sınıfının yeni bir örneğini başlatır.
/// </summary>
public OrdersController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Misafirin servis veya urun siparisini kaydeder.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Misafirin servis veya urun siparisini kaydeder.")]
        public async Task<ResponseDto<CreateOrderCommandResponse>> Create(CreateOrderCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
