using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.RoomTypes.Commands.CreateRoomType;
using WorigoApp.Application.Features.RoomTypes.Commands.UpdateRoomType;
using WorigoApp.Application.Features.RoomTypes.Commands.DeleteRoomType;
using WorigoApp.Application.Features.RoomTypes.Commands.ToggleRoomTypeStatus;
using WorigoApp.Application.Features.RoomTypes.Queries.GetByIdRoomType;
using WorigoApp.Application.Features.RoomTypes.Queries.GetRoomTypes;

namespace WorigoApp.Api.Controllers.Reception
{
    [ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/room-types")]
    public class RoomTypesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ResponseDto<IList<GetRoomTypesQueryResponse>>> GetRoomTypes([FromQuery] int hotelId, [FromQuery] bool? activeOnly)
        {
            var request = new GetRoomTypesQueryRequest(hotelId, activeOnly);
            var result = await _mediator.Send(request);
            return new ResponseDto<IList<GetRoomTypesQueryResponse>>().Success(result);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdRoomTypeQueryResponse>> GetById(int id)
        {
            var request = new GetByIdRoomTypeQueryRequest(id);
            return await _mediator.Send(request);
        }

        [HttpPost]
        public async Task<ResponseDto<CreateRoomTypeCommandResponse>> Create(CreateRoomTypeCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPut("{id}")]
        public async Task<ResponseDto<UpdateRoomTypeCommandResponse>> Update(int id, UpdateRoomTypeCommandRequest request)
        {
            request.Id = id;
            return await _mediator.Send(request);
        }

        [HttpDelete("{id}")]
        public async Task<ResponseDto<DeleteRoomTypeCommandResponse>> Delete(int id)
        {
            var request = new DeleteRoomTypeCommandRequest(id);
            return await _mediator.Send(request);
        }

        [HttpPatch("{id}/status")]
        public async Task<ResponseDto<ToggleRoomTypeStatusCommandResponse>> ToggleStatus(int id)
        {
            var request = new ToggleRoomTypeStatusCommandRequest(id);
            return await _mediator.Send(request);
        }
    }
}
