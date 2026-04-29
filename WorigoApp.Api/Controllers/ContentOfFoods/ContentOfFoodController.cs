using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Commands.AddContentOfFoodByFoodId;
using WorigoApp.Application.Features.ContentOfFoods.Commands.CreateContentOfFood;
using WorigoApp.Application.Features.ContentOfFoods.Commands.RemoveContentOfFoodByFoodId;
using WorigoApp.Application.Features.ContentOfFoods.Commands.UpdateContentOfFood;
using WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContent;
using WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContentByFoodId;
using WorigoApp.Application.Features.ContentOfFoods.Queries.GetByIdContent;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.ContentOfFoods
{
    [Authorize]
    public class ContentOfFoodController : BaseController
    {
        private readonly IMediator _mediator;
        public ContentOfFoodController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        [HttpPost]
        [SwaggerDescriptionAttirbute("Yeni içerik ekleme")]
        public async Task<ResponseDto<CreateContentOfFoodResponse>> CreateContentOfFoodAsync(CreateContentOfFoodRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        [SwaggerDescriptionAttirbute("İçerik güncelleme")]
        public async Task<ResponseDto<UpdateContentOfFoodResponse>> UpdateContentOfFoodAsync(UpdateContentOfFoodRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        [SwaggerDescriptionAttirbute("Menüden içerik çıkarma işlemini yapar.")]
        public async Task<ResponseDto<RemoveContentOfFoodByFoodIdResponse>> RemoveContentOfFoodAsync(RemoveContentOfFoodByFoodIdRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Menüye içerik ekleme işlemini yapar.")]
        public async Task<ResponseDto<AddContentOfFoodByFoodIdResponse>> AddContentOfFoodAsync(AddContentOfFoodByFoodIdRequest request, CancellationToken cancellationToken)
        {
            return await this._mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        [SwaggerDescriptionAttirbute("Tüm içerikleri listeler.")]
        public async Task<ResponseDto<IList<GetAllContentQueryResponse>>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetAllContentQueryRequest(), cancellationToken);
        }
        [HttpGet("{contentId}")]
        [SwaggerDescriptionAttirbute("Id bazlı içerik getirir.")]
        public async Task<ResponseDto<GetByIdContentQueryResponse>> GetContentByIdAsync(int contentId, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetByIdContentQueryRequest(contentId), cancellationToken);
        }
        [HttpGet]
        [SwaggerDescriptionAttirbute("Menü ait içerikleri listeler")]
        public async Task<ResponseDto<IList<GetAllContentByFoodIdResponse>>> GetContentByFoodId(int foodId, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetAllContentByFoodIdRequest(foodId), cancellationToken);
        }
    }
}
