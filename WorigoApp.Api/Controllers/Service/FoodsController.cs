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
    /// <summary>
    /// FoodsController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin")]
    public class FoodsController : BaseController
    {
        private readonly IMediator mediator;
/// <summary>
/// FoodsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public FoodsController(IMediator mediator) : base(mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// GetAllAsync işlemini gerçekleştirir.
        /// </summary>
[HttpGet("categoryId")]
        public async Task<ResponseDto<IList<GetAllFoodsQueryResponse>>> GetAllAsync(int categoryId)
        {
            return await this.mediator.Send(new GetAllFoodsQueryRequest(categoryId));
        }
        /// <summary>
        /// AddAsync işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<CreateFoodCommonResponse>> AddAsync(CreateFoodCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
        /// <summary>
        /// UpdateAsyn işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<UpdateFoodCommonResponse>> UpdateAsyn(UpdateFoodCommonRequest request)
        {
            return await this.mediator.Send(request);
        }
    }
}
