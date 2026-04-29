using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hr.Documents.Commands.CreateEmployeeDocument;
using WorigoApp.Application.Features.Hr.Documents.Queries.GetEmployeeDocuments;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hr
{
    [Authorize]
    public class EmployeeDocumentsController : BaseController
    {
        private readonly IMediator _mediator;

        public EmployeeDocumentsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Personel ozluk dosyasina evrak ekler.")]
        public async Task<ResponseDto<CreateEmployeeDocumentCommandResponse>> Create(CreateEmployeeDocumentCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("employee/{employeeId}")]
        [SwaggerDescriptionAttirbute("Personelin ozluk evraklarini listeler.")]
        public async Task<ResponseDto<IList<GetEmployeeDocumentsQueryResponse>>> GetByEmployee(int employeeId)
        {
            return await _mediator.Send(new GetEmployeeDocumentsQueryRequest { EmployeeId = employeeId });
        }
    }
}
