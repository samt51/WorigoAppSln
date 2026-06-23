using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Orders.Queries.GetFoodOrders;
using WorigoApp.Application.Features.Orders.Queries.GetFoodOrderDetails;
using WorigoApp.Application.Features.Orders.Queries.GetFoodOrderTracking;
using WorigoApp.Application.Features.Orders.Dtos;
using WorigoApp.Application.Features.Rooms.Queries.GetRoomAvailabilityStatus;
using WorigoApp.Application.Features.Rooms.Commands.UpdateRoomAvailabilityStatus;
using WorigoApp.Application.Features.ServiceRequestRatings.Commands.RateServiceRequest;
using WorigoApp.Application.Features.ServiceRequestRatings.Commands.RateOrder;
using WorigoApp.Application.Features.ServiceRequestRatings.Queries.GetMyRatings;
using WorigoApp.Application.Features.Restaurants.Queries.GetRestaurants;
using WorigoApp.Application.Features.Restaurants.Queries.GetRestaurant;
using WorigoApp.Application.Features.Restaurants.Queries.GetRestaurantSlots;
using WorigoApp.Application.Features.Restaurants.Queries.GetMyRestaurantReservations;
using WorigoApp.Application.Features.Restaurants.Commands.CreateRestaurantReservation;
using WorigoApp.Application.Features.Restaurants.Commands.CancelRestaurantReservation;
using WorigoApp.Application.Features.Transfers.Queries.GetTransfers;
using WorigoApp.Application.Features.Transfers.Queries.GetTransferTracking;
using WorigoApp.Application.Features.Concierge.Queries.GetConciergeCategories;
using WorigoApp.Application.Features.Concierge.Queries.GetConciergePlaces;
using WorigoApp.Application.Features.Concierge.Queries.GetConciergePlace;
using WorigoApp.Application.Features.Notifications.Queries.GetNotifications;
using WorigoApp.Application.Features.Notifications.Commands.MarkNotificationAsRead;
using WorigoApp.Application.Features.Spa.Queries.GetSpaServices;
using WorigoApp.Application.Features.Spa.Queries.GetSpaSlots;
using WorigoApp.Application.Features.Spa.Queries.GetSpaAppointments;
using WorigoApp.Application.Features.Spa.Commands.CreateSpaAppointment;
using WorigoApp.Application.Features.Spa.Commands.CancelSpaAppointment;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("guest")]
    public class GuestOperationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GuestOperationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region 1. Yemek Sipariş Takibi

        [HttpGet("orders/food")]
        public async Task<ResponseDto<IList<Order>>> GetFoodOrders([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetFoodOrdersQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("orders/food/{orderId:int}")]
        public async Task<ResponseDto<Order>> GetFoodOrderDetails(int orderId, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetFoodOrderDetailsQueryRequest { OrderId = orderId, SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("orders/food/{orderId:int}/tracking")]
        public async Task<ResponseDto<OrderTrackingDto>> GetFoodOrderTracking(int orderId, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetFoodOrderTrackingQueryRequest { OrderId = orderId, SessionToken = sessionToken }, cancellationToken);
        }

        #endregion

        #region 2. Housekeeping / Oda Durum Yönetimi

        [HttpGet("room/availability-status")]
        public async Task<ResponseDto<RoomAvailabilityStatusResponse>> GetRoomAvailabilityStatus([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetRoomAvailabilityStatusQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpPut("room/availability-status")]
        public async Task<ResponseDto<bool>> UpdateRoomAvailabilityStatus([FromBody] UpdateRoomAvailabilityStatusCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        #endregion

        #region 3. Memnuniyet / Rating

        [HttpPost("ratings/service-request")]
        public async Task<ResponseDto<bool>> RateServiceRequest([FromBody] RateServiceRequestCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        [HttpPost("ratings/order")]
        public async Task<ResponseDto<bool>> RateOrder([FromBody] RateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        [HttpGet("ratings/my")]
        public async Task<ResponseDto<IList<ServiceRequestRating>>> GetMyRatings([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetMyRatingsQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        #endregion

        #region 4. Restaurant Rezervasyon Modülü

        [HttpGet("restaurants")]
        public async Task<ResponseDto<IList<Restaurant>>> GetRestaurants([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetRestaurantsQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("restaurants/{restaurantId:int}")]
        public async Task<ResponseDto<Restaurant>> GetRestaurant(int restaurantId, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetRestaurantQueryRequest { RestaurantId = restaurantId, SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("restaurants/{restaurantId:int}/slots")]
        public async Task<ResponseDto<IList<string>>> GetRestaurantSlots(int restaurantId, [FromQuery] string date, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetRestaurantSlotsQueryRequest { RestaurantId = restaurantId, Date = date, SessionToken = sessionToken }, cancellationToken);
        }

        [HttpPost("restaurants/reservations")]
        public async Task<ResponseDto<RestaurantReservation>> CreateRestaurantReservation([FromBody] CreateRestaurantReservationCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        [HttpGet("restaurants/my-reservations")]
        public async Task<ResponseDto<IList<RestaurantReservation>>> GetMyRestaurantReservations([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetMyRestaurantReservationsQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpPut("restaurants/reservations/{id:int}/cancel")]
        public async Task<ResponseDto<bool>> CancelRestaurantReservation(int id, [FromBody] CancelReservationRequestModel request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new CancelRestaurantReservationCommandRequest { Id = id, SessionToken = request.SessionToken }, cancellationToken);
        }

        #endregion

        #region 5. Transfer Takip Modülü

        [HttpGet("transfers")]
        public async Task<ResponseDto<IList<TransferTracking>>> GetTransfers([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetTransfersQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("transfers/{serviceRequestId:int}/tracking")]
        public async Task<ResponseDto<TransferTracking>> GetTransferTracking(int serviceRequestId, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetTransferTrackingQueryRequest { ServiceRequestId = serviceRequestId, SessionToken = sessionToken }, cancellationToken);
        }

        #endregion

        #region 6. Digital Concierge

        [HttpGet("concierge/categories")]
        public async Task<ResponseDto<IList<string>>> GetConciergeCategories([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetConciergeCategoriesQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("concierge/places")]
        public async Task<ResponseDto<IList<ConciergePlace>>> GetConciergePlaces([FromQuery] string sessionToken, [FromQuery] string? category, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetConciergePlacesQueryRequest { SessionToken = sessionToken, Category = category }, cancellationToken);
        }

        [HttpGet("concierge/places/{id:int}")]
        public async Task<ResponseDto<ConciergePlace>> GetConciergePlace(int id, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetConciergePlaceQueryRequest { Id = id, SessionToken = sessionToken }, cancellationToken);
        }

        #endregion

        #region 7. Guest Notification / Proaktif Öneriler

        [HttpGet("notifications")]
        public async Task<ResponseDto<IList<GuestNotification>>> GetNotifications([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetNotificationsQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpPut("notifications/{id:int}/read")]
        public async Task<ResponseDto<bool>> MarkNotificationAsRead(int id, [FromBody] MarkNotificationReadRequestModel request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new MarkNotificationAsReadCommandRequest { Id = id, SessionToken = request.SessionToken }, cancellationToken);
        }

        #endregion

        #region 8. SPA İyileştirme

        [HttpGet("spa/services")]
        public async Task<ResponseDto<IList<SpaService>>> GetSpaServices([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetSpaServicesQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpGet("spa/slots")]
        public async Task<ResponseDto<IList<string>>> GetSpaSlots([FromQuery] string date, [FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetSpaSlotsQueryRequest { Date = date, SessionToken = sessionToken }, cancellationToken);
        }

        [HttpPost("spa/appointments")]
        public async Task<ResponseDto<SpaAppointment>> CreateSpaAppointment([FromBody] CreateSpaAppointmentCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }

        [HttpGet("spa/appointments")]
        public async Task<ResponseDto<IList<SpaAppointment>>> GetSpaAppointments([FromQuery] string sessionToken, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetSpaAppointmentsQueryRequest { SessionToken = sessionToken }, cancellationToken);
        }

        [HttpPut("spa/appointments/{id:int}/cancel")]
        public async Task<ResponseDto<bool>> CancelSpaAppointment(int id, [FromBody] CancelSpaAppointmentRequestModel request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new CancelSpaAppointmentCommandRequest { Id = id, SessionToken = request.SessionToken }, cancellationToken);
        }

        #endregion
    }

    #region Models

    public class CancelReservationRequestModel
    {
        public string SessionToken { get; set; } = string.Empty;
    }

    public class MarkNotificationReadRequestModel
    {
        public string SessionToken { get; set; } = string.Empty;
    }

    public class CancelSpaAppointmentRequestModel
    {
        public string SessionToken { get; set; } = string.Empty;
    }

    #endregion
}
