using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Stock.Commands.CreateStockItem;
using WorigoApp.Application.Features.Stock.Commands.CreateStockMovement;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Stock
{
    /// <summary>
    /// StockItemsController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class StockItemsController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// StockItemsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public StockItemsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Otel icin yeni stok karti olusturur.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Otel icin yeni stok karti olusturur.")]
        public async Task<ResponseDto<CreateStockItemCommandResponse>> Create(CreateStockItemCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Stok giris, cikis ve alim hareketlerini kaydeder.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Stok giris, cikis ve alim hareketlerini kaydeder.")]
        public async Task<ResponseDto<CreateStockMovementCommandResponse>> CreateMovement(CreateStockMovementCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
