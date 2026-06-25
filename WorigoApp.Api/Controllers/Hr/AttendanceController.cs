using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hr.Attendance.Commands.UpsertAttendanceRecord;
using WorigoApp.Application.Features.Hr.Attendance.Queries.GetAttendanceByEmployee;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Hr
{
    /// <summary>
    /// AttendanceController sınıfını temsil eder.
    /// </summary>
[Authorize]
    public class AttendanceController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// AttendanceController sınıfının yeni bir örneğini başlatır.
/// </summary>
public AttendanceController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Personelin gunluk yoklama ve giris-cikis kaydini olusturur veya gunceller.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Personelin gunluk yoklama ve giris-cikis kaydini olusturur veya gunceller.")]
        public async Task<ResponseDto<UpsertAttendanceRecordCommandResponse>> Upsert(UpsertAttendanceRecordCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Personelin devam ve mesai kayitlarini listeler.
        /// </summary>
[HttpGet("employee/{employeeId}")]
        [SwaggerDescriptionAttirbute("Personelin devam ve mesai kayitlarini listeler.")]
        public async Task<ResponseDto<IList<GetAttendanceByEmployeeQueryResponse>>> GetByEmployee(int employeeId)
        {
            return await _mediator.Send(new GetAttendanceByEmployeeQueryRequest { EmployeeId = employeeId });
        }
    }
}
