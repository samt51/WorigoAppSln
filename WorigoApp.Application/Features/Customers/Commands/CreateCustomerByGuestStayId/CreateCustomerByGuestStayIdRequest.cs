using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Customers.Commands.CreateCustomerByGuestStayId
{
    public class CreateCustomerByGuestStayIdRequest : IRequest<ResponseDto<CreateCustomerByGuestStayIdResponse>>
    {
        public int GuestStayId { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public bool Gender { get; set; }
        public CreateCustomerByGuestStayIdRequest(int guestStayId, string name, string surName, bool gender)
        {
            this.GuestStayId = guestStayId;
            this.Name = name;
            this.SurName = surName;
            this.Gender = gender;
        }
    }
}
