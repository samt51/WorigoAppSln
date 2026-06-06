using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ServiceRequests.Commands.CreateServiceRequest;
using WorigoApp.Application.Features.ServiceRequests.Commands.UpdateServiceRequestStatus;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetAssignedServiceRequests;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByDepartment;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByGuestStay;
using WorigoApp.Application.Features.ServiceRequests.Queries.GetServiceRequestsByHotel;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.ServiceRequests
{
    [Authorize]
    public class ServiceRequestsController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IHubContext<HotelOperationsHub> _hubContext;

        public ServiceRequestsController(IMediator mediator, IHubContext<HotelOperationsHub> hubContext) : base(mediator)
        {
            _mediator = mediator;
            _hubContext = hubContext;
        }

        [HttpPost]
        [SwaggerDescriptionAttirbute("Misafir veya personel tarafindan yeni servis talebi olusturur.")]
        public async Task<ResponseDto<CreateServiceRequestCommandResponse>> Create(CreateServiceRequestCommandRequest request)
        {
            var response = await _mediator.Send(request);

            if (response.IsSuccess && response.Data is not null)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(response.Data.HotelId))
                    .SendAsync("ServiceRequestCreated", response.Data);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(response.Data.HotelId))
                    .SendAsync("ServiceRequestCreated", response.Data);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("ServiceRequestCreated", response.Data);

                if (response.Data.DepartmentId.HasValue)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Department(response.Data.DepartmentId.Value))
                        .SendAsync("ServiceRequestCreated", response.Data);
                }

                if (response.Data.AssignedEmployeeId.HasValue)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(response.Data.AssignedEmployeeId.Value))
                        .SendAsync("ServiceRequestAssigned", response.Data);
                }

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(response.Data.HotelId))
                    .SendAsync("NotificationReceived", response.Data);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(response.Data.HotelId))
                    .SendAsync("NotificationReceived", response.Data);

                foreach (var receptionEmployeeId in response.Data.ReceptionEmployeeIds)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(receptionEmployeeId))
                        .SendAsync("NotificationReceived", response.Data);
                }
            }

            return response;
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

        [HttpPost("status")]
        [SwaggerDescriptionAttirbute("Servis talebinin durumunu gunceller.")]
        public async Task<ResponseDto<UpdateServiceRequestStatusCommandResponse>> UpdateStatus(UpdateServiceRequestStatusCommandRequest request)
        {
            var response = await _mediator.Send(request);

            if (response.IsSuccess && response.Data is not null)
            {
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Hotel(response.Data.HotelId))
                    .SendAsync("ServiceRequestUpdated", response.Data);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Reception(response.Data.HotelId))
                    .SendAsync("ServiceRequestUpdated", response.Data);

                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("ServiceRequestUpdated", response.Data);

                if (response.Data.DepartmentId.HasValue)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Department(response.Data.DepartmentId.Value))
                        .SendAsync("ServiceRequestUpdated", response.Data);
                }

                if (response.Data.AssignedEmployeeId.HasValue)
                {
                    await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.Employee(response.Data.AssignedEmployeeId.Value))
                        .SendAsync("ServiceRequestUpdated", response.Data);
                }
            }

            return response;
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

        [HttpGet("hotel/{hotelId}")]
        [SwaggerDescriptionAttirbute("Otele ait tum servis taleplerini listeler. Resepsiyon ekrani bu endpointi kullanabilir.")]
        public async Task<ResponseDto<IList<GetServiceRequestsByHotelQueryResponse>>> GetByHotel(int hotelId)
        {
            return await _mediator.Send(new GetServiceRequestsByHotelQueryRequest
            {
                HotelId = hotelId
            });
        }
    }
}
