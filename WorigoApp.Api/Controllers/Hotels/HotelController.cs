using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hotels.Commands.CreateHotel;
using WorigoApp.Application.Features.Hotels.Commands.DeleteHotel;
using WorigoApp.Application.Features.Hotels.Commands.UpdateHotel;
using WorigoApp.Application.Features.Hotels.Queries.GetAllHotels;
using WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hotels
{
    [Authorize(Roles = "SystemAdmin")]
    public class HotelController : BaseController
    {
        private readonly IMediator _mediator;
        public HotelController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<ResponseDto<IList<GetAllHotelsQueryResponse>>> GetAllAsync([FromQuery] int companyId)
        {
            var result = await this._mediator.Send(new GetAllHotelsQueryRequest(companyId));
            return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Success(result);
        }

        [HttpPost]
        public async Task<ResponseDto<CreateHotelCommonResponse>> AddAsync(CreateHotelCommonRequest request)
        {
            return await this._mediator.Send(request);
        }

        [HttpPost]
        public async Task<ResponseDto<UpdateHotelCommonResponse>> UpdateAsync(UpdateHotelCommonRequest request)
        {
            return await this._mediator.Send(request);
        }

        [HttpPost]
        public async Task<ResponseDto<DeleteHotelCommandResponse>> DeleteAsync(DeleteHotelCommandRequest request)
        {
            return await this._mediator.Send(request);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdHotelQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdHotelQueryRequest(id));
        }
    }
}
