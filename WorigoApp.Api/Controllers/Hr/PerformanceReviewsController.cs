using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hr.Performance.Commands.CreatePerformanceReview;
using WorigoApp.Application.Features.Hr.Performance.Queries.GetPerformanceReviewsByEmployee;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hr
{
    /// <summary>
    /// PerformanceReviewsController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class PerformanceReviewsController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// PerformanceReviewsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public PerformanceReviewsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Personel icin yonetici performans degerlendirmesi olusturur.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Personel icin yonetici performans degerlendirmesi olusturur.")]
        public async Task<ResponseDto<CreatePerformanceReviewCommandResponse>> Create(CreatePerformanceReviewCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Personelin performans degerlendirmelerini listeler.
        /// </summary>
[HttpGet("employee/{employeeId}")]
        [SwaggerDescriptionAttirbute("Personelin performans degerlendirmelerini listeler.")]
        public async Task<ResponseDto<IList<GetPerformanceReviewsByEmployeeQueryResponse>>> GetByEmployee(int employeeId)
        {
            return await _mediator.Send(new GetPerformanceReviewsByEmployeeQueryRequest { EmployeeId = employeeId });
        }
    }
}
