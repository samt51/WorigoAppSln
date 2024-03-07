using MediatR;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Features.Foods.Commands.CreateFood;
using WorigoApp.Application.Features.Foods.Commands.UpdateFood;
using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;

namespace WorigoApp.Api.Controllers.Service
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IMediator mediator;

        public FoodsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("categoryId")]
        public async Task<IActionResult> Get(int categoryId)
        {
            return Ok(await this.mediator.Send(new GetAllFoodsQueryRequest(categoryId));
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateFoodCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAsyn(UpdateFoodCommonRequest request)
        {
            return Ok(await this.mediator.Send(request));
        }
    }
}
