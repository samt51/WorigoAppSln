using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommonRequest : IRequest<Response<CreateHotelCommonResponse>>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfStar { get; set; }
        public int Companyid { get; set; }
        public CreateHotelCommonRequest(string name, string location, string adress, string phoneNumber, string email, int numberOfStar, int companyId)
        {
            this.Name = name;
            this.Location = location;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.NumberOfStar = numberOfStar;
            this.Companyid = companyId;
        }
    }
}
