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
    [Authorize]
    public class EmployeeTasksController : BaseController
    {
        private readonly IMediator _mediator;

        public EmployeeTasksController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Personel icin yonetici gorevi olusturur.")]
        public async Task<ResponseDto<CreateEmployeeTaskCommandResponse>> Create(CreateEmployeeTaskCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Ic gorevin durumunu gunceller.")]
        public async Task<ResponseDto<UpdateEmployeeTaskStatusCommandResponse>> UpdateStatus(UpdateEmployeeTaskStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet]
        [SwaggerDescriptionAttirbute("Personel veya departman bazli ic gorevleri listeler.")]
        public async Task<ResponseDto<IList<GetEmployeeTasksQueryResponse>>> Get([FromQuery] GetEmployeeTasksQueryRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
