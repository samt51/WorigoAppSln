using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus;

namespace WorigoApp.Api.Controllers.Service
{
    /// <summary>
    /// ServiceCatalogController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin")]
    public class ServiceCatalogController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// ServiceCatalogController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ServiceCatalogController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// ToggleStatus işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        public async Task<ResponseDto<ToggleServiceCatalogStatusCommandResponse>> ToggleStatus(ToggleServiceCatalogStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
