using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.GuestStays.Commands.UpdatedCustomer;

namespace WorigoApp.Application.Features.GuestStays.Rules
{
    public class GuestStayRule : BaseRules
    {
        public Task ControllCheckInAndCheckOutDates(UpdatedCustomerCommandRequest updatedCustomerCommandRequest)
        {
            if (updatedCustomerCommandRequest.CheckInDate >= DateTime.Now && updatedCustomerCommandRequest.CheckOutDate >= DateTime.Now)
            {
                throw new Exception("Giriþ ve Çýkýþ tarihleri geçmiz zaman olamaz.");
            }
            return Task.CompletedTask;
        }
    }
}
