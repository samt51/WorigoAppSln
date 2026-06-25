using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hr.Tasks.Commands.CreateEmployeeTask;
using WorigoApp.Application.Features.Hr.Tasks.Commands.UpdateEmployeeTaskStatus;
using WorigoApp.Application.Features.Hr.Tasks.Queries.GetEmployeeTasks;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hr
{
    /// <summary>
    /// EmployeeTasksController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class EmployeeTasksController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// EmployeeTasksController sınıfının yeni bir örneğini başlatır.
/// </summary>
public EmployeeTasksController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Personel icin yonetici gorevi olusturur.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Personel icin yonetici gorevi olusturur.")]
        public async Task<ResponseDto<CreateEmployeeTaskCommandResponse>> Create(CreateEmployeeTaskCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Ic gorevin durumunu gunceller.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Ic gorevin durumunu gunceller.")]
        public async Task<ResponseDto<UpdateEmployeeTaskStatusCommandResponse>> UpdateStatus(UpdateEmployeeTaskStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Personel veya departman bazli ic gorevleri listeler.
        /// </summary>
[HttpGet]
        [SwaggerDescriptionAttirbute("Personel veya departman bazli ic gorevleri listeler.")]
        public async Task<ResponseDto<IList<GetEmployeeTasksQueryResponse>>> Get([FromQuery] GetEmployeeTasksQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
