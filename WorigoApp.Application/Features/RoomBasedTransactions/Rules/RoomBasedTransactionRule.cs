using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.RoomBasedTransactions.Commands.UpdatedCustomer;

namespace WorigoApp.Application.Features.RoomBasedTransactions.Rules
{
    public class RoomBasedTransactionRule : BaseRules
    {
        public Task ControllCheckInAndCheckOutDates(UpdatedCustomerCommandRequest updatedCustomerCommandRequest)
        {
            if (updatedCustomerCommandRequest.CheckInDate >= DateTime.Now && updatedCustomerCommandRequest.CheckOutDate >= DateTime.Now)
            {
                throw new Exception("Giriş ve Çıkış tarihleri geçmiz zaman olamaz.");
            }
            return Task.CompletedTask;
        }
    }
}
