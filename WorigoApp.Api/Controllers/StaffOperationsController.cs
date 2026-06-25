using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Transfers.Commands.AssignDriver;
using WorigoApp.Application.Features.Transfers.Commands.UpdateTransferStatus;

namespace WorigoApp.Api.Controllers
{
    /// <summary>
    /// StaffOperationsController sınıfını temsil eder.
    /// </summary>
[ApiController]
    [Authorize(Roles = "HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("staff")]
    public class StaffOperationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHubContext<HotelOperationsHub> _hubContext;
/// <summary>
/// StaffOperationsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public StaffOperationsController(IMediator mediator, IHubContext<HotelOperationsHub> hubContext)
        {
            _mediator = mediator;
            _hubContext = hubContext;
        }



        #region 5. Transfer Takip Modülü

        /// <summary>
        /// AssignDriver işlemini gerçekleştirir.
        /// </summary>
[HttpPut("transfers/{serviceRequestId:int}/assign-driver")]
        public async Task<ResponseDto<bool>> AssignDriver(int serviceRequestId, [FromBody] AssignDriverRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new AssignDriverCommandRequest
            {
                ServiceRequestId = serviceRequestId,
                DriverName = request.DriverName,
                DriverPhone = request.DriverPhone,
                VehiclePlate = request.VehiclePlate,
                VehicleModel = request.VehicleModel,
                EstimatedArrivalTime = request.EstimatedArrivalTime
            }, cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                // Notify guest stay group via SignalR
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("TransferStatusChanged", new
                    {
                        ServiceRequestId = serviceRequestId,
                        Status = "Assigned",
                        DriverName = response.Data.DriverName,
                        VehiclePlate = response.Data.VehiclePlate,
                        EstimatedArrivalTime = response.Data.EstimatedArrivalTime,
                        UpdatedAt = DateTime.UtcNow
                    }, cancellationToken);

                return new ResponseDto<bool>().Success(true);
            }

            return new ResponseDto<bool>().Fail(response.Errors ?? new List<string> { "Sürücü atanamadı." }, response.StatusCode);
        }

        /// <summary>
        /// UpdateTransferStatus işlemini gerçekleştirir.
        /// </summary>
[HttpPut("transfers/{serviceRequestId:int}/status")]
        public async Task<ResponseDto<bool>> UpdateTransferStatus(int serviceRequestId, [FromBody] UpdateTransferStatusRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new UpdateTransferStatusCommandRequest
            {
                ServiceRequestId = serviceRequestId,
                Status = request.Status
            }, cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                // Notify guest stay group via SignalR
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("TransferStatusChanged", new
                    {
                        ServiceRequestId = serviceRequestId,
                        Status = response.Data.Status,
                        UpdatedAt = DateTime.UtcNow
                    }, cancellationToken);

                return new ResponseDto<bool>().Success(true);
            }

            return new ResponseDto<bool>().Fail(response.Errors ?? new List<string> { "Transfer durumu güncellenemedi." }, response.StatusCode);
        }

        #endregion
    }

    #region Models

/// <summary>
/// AssignDriverRequest sınıfını temsil eder.
/// </summary>
public class AssignDriverRequest
    {
/// <summary>
/// DriverName değerini alır veya ayarlar.
/// </summary>
public string DriverName { get; set; } = string.Empty;
/// <summary>
/// DriverPhone değerini alır veya ayarlar.
/// </summary>
public string DriverPhone { get; set; } = string.Empty;
/// <summary>
/// VehiclePlate değerini alır veya ayarlar.
/// </summary>
public string VehiclePlate { get; set; } = string.Empty;
/// <summary>
/// VehicleModel değerini alır veya ayarlar.
/// </summary>
public string VehicleModel { get; set; } = string.Empty;
/// <summary>
/// EstimatedArrivalTime değerini alır veya ayarlar.
/// </summary>
public DateTime? EstimatedArrivalTime { get; set; }
    }

/// <summary>
/// UpdateTransferStatusRequest sınıfını temsil eder.
/// </summary>
public class UpdateTransferStatusRequest
    {
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
    }

    #endregion
}
