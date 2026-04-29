using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Stock.Commands.CreateStockRequest;
using WorigoApp.Application.Features.Stock.Commands.UpdateStockRequestStatus;
using WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByHotel;
using WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByManager;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Stock
{
    [Authorize]
    public class StockRequestsController : BaseController
    {
        private readonly IMediator _mediator;

        public StockRequestsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Personel veya departman icin stok talebi olusturur.")]
        public async Task<ResponseDto<CreateStockRequestCommandResponse>> Create(CreateStockRequestCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Stok talebinin durumunu gunceller ve karsilandiysa stoktan dusum yapar.")]
        public async Task<ResponseDto<UpdateStockRequestStatusCommandResponse>> UpdateStatus(UpdateStockRequestStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("{hotelId}")]
        [SwaggerDescriptionAttirbute("Otele ait stok taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetStockRequestsByHotelQueryResponse>>> GetByHotel(int hotelId)
        {
            return await _mediator.Send(new GetStockRequestsByHotelQueryRequest { HotelId = hotelId });
        }

        [HttpGet("{managerEmployeeId}")]
        [SwaggerDescriptionAttirbute("Satin alma yoneticisine dusen stok taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetStockRequestsByManagerQueryResponse>>> GetByManager(int managerEmployeeId)
        {
            return await _mediator.Send(new GetStockRequestsByManagerQueryRequest { ManagerEmployeeId = managerEmployeeId });
        }
    }
}
