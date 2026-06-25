using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using WorigoApp.Api.Hubs;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Orders.Commands.UpdateFoodOrderStatus;
using WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantReservations;
using WorigoApp.Application.Features.Restaurants.Commands.ApproveRestaurantReservation;
using WorigoApp.Application.Features.Restaurants.Commands.RejectRestaurantReservation;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Api.Controllers
{
    /// <summary>
    /// AdminOperationsController sınıfını temsil eder.
    /// </summary>
[ApiController]
    [Authorize(Roles = "HotelAdmin,Management")]
    [Route("admin")]
    public class AdminOperationsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IHubContext<HotelOperationsHub> _hubContext;
/// <summary>
/// AdminOperationsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public AdminOperationsController(IMediator mediator, IHubContext<HotelOperationsHub> hubContext)
        {
            _mediator = mediator;
            _hubContext = hubContext;
        }



        #region 1. Yemek Sipariş Takibi

        /// <summary>
        /// UpdateFoodOrderStatus işlemini gerçekleştirir.
        /// </summary>
[HttpPut("orders/food/{orderId:int}/status")]
        public async Task<ResponseDto<bool>> UpdateFoodOrderStatus(int orderId, [FromBody] UpdateFoodOrderStatusRequest request, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new UpdateFoodOrderStatusCommandRequest
            {
                OrderId = orderId,
                Status = request.Status
            }, cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                // Trigger SignalR notification to guest stay group
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("OrderStatusChanged", new
                    {
                        OrderId = response.Data.OrderId,
                        Status = response.Data.OrderStatus.ToString(),
                        StatusValue = (int)response.Data.OrderStatus,
                        UpdatedAt = response.Data.UpdatedAt
                    }, cancellationToken);

                return new ResponseDto<bool>().Success(true);
            }

            return new ResponseDto<bool>().Fail(response.Errors ?? new List<string> { "Sipariş durumu güncellenemedi." }, response.StatusCode);
        }

        #endregion

        #region 4. Restaurant Rezervasyon Modülü

        /// <summary>
        /// GetRestaurantReservations işlemini gerçekleştirir.
        /// </summary>
[HttpGet("restaurants/reservations")]
        public async Task<ResponseDto<IList<RestaurantReservation>>> GetRestaurantReservations(CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetRestaurantReservationsQueryRequest(), cancellationToken);
        }

        /// <summary>
        /// ApproveRestaurantReservation işlemini gerçekleştirir.
        /// </summary>
[HttpPut("restaurants/reservations/{id:int}/approve")]
        public async Task<ResponseDto<bool>> ApproveRestaurantReservation(int id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new ApproveRestaurantReservationCommandRequest
            {
                Id = id
            }, cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                // SignalR notification to guest stay group
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("RestaurantReservationUpdated", new
                    {
                        ReservationId = response.Data.ReservationId,
                        Status = "Approved",
                        UpdatedAt = DateTime.UtcNow
                    }, cancellationToken);

                return new ResponseDto<bool>().Success(true);
            }

            return new ResponseDto<bool>().Fail(response.Errors ?? new List<string> { "Rezervasyon onaylanamadı." }, response.StatusCode);
        }

        /// <summary>
        /// RejectRestaurantReservation işlemini gerçekleştirir.
        /// </summary>
[HttpPut("restaurants/reservations/{id:int}/reject")]
        public async Task<ResponseDto<bool>> RejectRestaurantReservation(int id, CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new RejectRestaurantReservationCommandRequest
            {
                Id = id
            }, cancellationToken);

            if (response.IsSuccess && response.Data is not null)
            {
                // SignalR notification to guest stay group
                await _hubContext.Clients.Group(HotelOperationsHub.GroupNames.GuestStay(response.Data.GuestStayId))
                    .SendAsync("RestaurantReservationUpdated", new
                    {
                        ReservationId = response.Data.ReservationId,
                        Status = "Rejected",
                        UpdatedAt = DateTime.UtcNow
                    }, cancellationToken);

                return new ResponseDto<bool>().Success(true);
            }

            return new ResponseDto<bool>().Fail(response.Errors ?? new List<string> { "Rezervasyon reddedilemedi." }, response.StatusCode);
        }

        #endregion
    }

    #region Models

/// <summary>
/// UpdateFoodOrderStatusRequest sınıfını temsil eder.
/// </summary>
public class UpdateFoodOrderStatusRequest
    {
/// <summary>
/// Status değerini alır veya ayarlar.
/// </summary>
public string Status { get; set; } = string.Empty;
    }

    #endregion
}
