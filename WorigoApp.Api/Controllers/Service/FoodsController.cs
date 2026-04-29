using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Foods.Commands.CreateFood;
using WorigoApp.Application.Features.Foods.Commands.UpdateFood;
using WorigoApp.Application.Features.Foods.Queries.GetAllFoods;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize(Roles = "SystemAdmin")]
    public class FoodsController : BaseController
    {
        private readonly IMediator mediator;

        public FoodsController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("categoryId")]
        public async Task<ResponseDto<IList<GetAllFoodsQueryResponse>>> GetAllAsync(int categoryId)
        {
            return await this.mediator.Send(new GetAllFoodsQueryRequest(categoryId));
        }
        [HttpPost]
        public async Task<ResponseDto<CreateFoodCommonResponse>> AddAsync(CreateFoodCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateFoodCommonResponse>> UpdateAsyn(UpdateFoodCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}
