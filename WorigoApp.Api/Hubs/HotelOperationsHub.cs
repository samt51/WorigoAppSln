using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace WorigoApp.Api.Hubs
{
    /// <summary>
    /// HotelOperationsHub sınıfını temsil eder.
    /// </summary>
    [AllowAnonymous]
    public class HotelOperationsHub : Hub
    {
/// <summary>
/// JoinHotel işlemini gerçekleştirir.
/// </summary>
public Task JoinHotel(int hotelId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Hotel(hotelId));
        }
/// <summary>
/// JoinReception işlemini gerçekleştirir.
/// </summary>
public Task JoinReception(int hotelId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Reception(hotelId));
        }
/// <summary>
/// JoinDepartment işlemini gerçekleştirir.
/// </summary>
public Task JoinDepartment(int departmentId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Department(departmentId));
        }
/// <summary>
/// JoinEmployee işlemini gerçekleştirir.
/// </summary>
public Task JoinEmployee(int employeeId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Employee(employeeId));
        }
/// <summary>
/// JoinGuestStay işlemini gerçekleştirir.
/// </summary>
public Task JoinGuestStay(int guestStayId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.GuestStay(guestStayId));
        }
/// <summary>
/// JoinServiceRequest işlemini gerçekleştirir.
/// </summary>
public Task JoinServiceRequest(int serviceRequestId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.ServiceRequest(serviceRequestId));
        }

        /// <summary>
        /// GroupNames sınıfını temsil eder.
        /// </summary>
        public static class GroupNames
        {
/// <summary>
/// Hotel işlemini gerçekleştirir.
/// </summary>
public static string Hotel(int hotelId) => $"hotel-{hotelId}";
/// <summary>
/// Reception işlemini gerçekleştirir.
/// </summary>
public static string Reception(int hotelId) => $"reception-{hotelId}";
/// <summary>
/// Department işlemini gerçekleştirir.
/// </summary>
public static string Department(int departmentId) => $"department-{departmentId}";
/// <summary>
/// Employee işlemini gerçekleştirir.
/// </summary>
public static string Employee(int employeeId) => $"employee-{employeeId}";
/// <summary>
/// GuestStay işlemini gerçekleştirir.
/// </summary>
public static string GuestStay(int guestStayId) => $"guest-stay-{guestStayId}";
/// <summary>
/// ServiceRequest işlemini gerçekleştirir.
/// </summary>
public static string ServiceRequest(int serviceRequestId) => $"service-request-{serviceRequestId}";
        }
    }
}
