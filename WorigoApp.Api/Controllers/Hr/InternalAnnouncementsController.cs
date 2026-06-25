using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hr.InternalAnnouncements.Commands.CreateInternalAnnouncement;
using WorigoApp.Application.Features.Hr.InternalAnnouncements.Queries.GetInternalAnnouncements;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hr
{
    /// <summary>
    /// InternalAnnouncementsController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class InternalAnnouncementsController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// InternalAnnouncementsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public InternalAnnouncementsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Personel ve yonetime gosterilecek ic duyuru olusturur.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Personel ve yonetime gosterilecek ic duyuru olusturur.")]
        public async Task<ResponseDto<CreateInternalAnnouncementCommandResponse>> Create(CreateInternalAnnouncementCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Ic duyurulari listeler.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Ic duyurulari listeler.")]
        public async Task<ResponseDto<IList<GetInternalAnnouncementsQueryResponse>>> Get([FromQuery] GetInternalAnnouncementsQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
