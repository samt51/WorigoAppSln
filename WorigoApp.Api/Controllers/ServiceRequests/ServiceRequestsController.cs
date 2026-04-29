using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest;
using WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByDepartment;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.ServiceRequests
{
    [Authorize]
    public class ServiceRequestsController : BaseController
    {
        private readonly IMediator _mediator;

        public ServiceRequestsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Misafir veya personel tarafindan yeni servis talebi olusturur.")]
        public async Task<ResponseDto<CreateServiceRequestCommandResponse>> Create(CreateServiceRequestCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("guest-stay/{guestStayId}")]
        [SwaggerDescriptionAttirbute("Konaklama kaydina ait servis taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetServiceRequestsByGuestStayQueryResponse>>> GetByGuestStay(int guestStayId)
        {
            return await _mediator.Send(new GetServiceRequestsByGuestStayQueryRequest
            {
                GuestStayId = guestStayId
            });
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Servis talebinin durumunu gunceller.")]
        public async Task<ResponseDto<UpdateServiceRequestStatusCommandResponse>> UpdateStatus(UpdateServiceRequestStatusCommandRequest request)
        {
            return await _mediator.Send(request);
        }

        [HttpGet("assigned/{employeeId}")]
        [SwaggerDescriptionAttirbute("Personele atanmis servis taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetAssignedServiceRequestsQueryResponse>>> GetAssigned(int employeeId)
        {
            return await _mediator.Send(new GetAssignedServiceRequestsQueryRequest
            {
                EmployeeId = employeeId
            });
        }

        [HttpGet("department/{departmentId}")]
        [SwaggerDescriptionAttirbute("Departmana gelen servis taleplerini listeler.")]
        public async Task<ResponseDto<IList<GetServiceRequestsByDepartmentQueryResponse>>> GetByDepartment(int departmentId)
        {
            return await _mediator.Send(new GetServiceRequestsByDepartmentQueryRequest
            {
                DepartmentId = departmentId
            });
        }
    }
}
