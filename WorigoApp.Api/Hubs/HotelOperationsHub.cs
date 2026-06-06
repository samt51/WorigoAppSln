using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace WorigoApp.Api.Hubs
{
    [AllowAnonymous]
    public class HotelOperationsHub : Hub
    {
        public Task JoinHotel(int hotelId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Hotel(hotelId));
        }

        public Task JoinReception(int hotelId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Reception(hotelId));
        }

        public Task JoinDepartment(int departmentId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Department(departmentId));
        }

        public Task JoinEmployee(int employeeId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.Employee(employeeId));
        }

        public Task JoinGuestStay(int guestStayId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.GuestStay(guestStayId));
        }

        public Task JoinServiceRequest(int serviceRequestId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, GroupNames.ServiceRequest(serviceRequestId));
        }

        public static class GroupNames
        {
            public static string Hotel(int hotelId) => $"hotel-{hotelId}";
            public static string Reception(int hotelId) => $"reception-{hotelId}";
            public static string Department(int departmentId) => $"department-{departmentId}";
            public static string Employee(int employeeId) => $"employee-{employeeId}";
            public static string GuestStay(int guestStayId) => $"guest-stay-{guestStayId}";
            public static string ServiceRequest(int serviceRequestId) => $"service-request-{serviceRequestId}";
        }
    }
}
