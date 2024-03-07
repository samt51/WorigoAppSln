using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Commands.UpdateHotel
{
    public class UpdateHotelCommonRequest :IRequest<Response<UpdateHotelCommonResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfStar { get; set; }
        public UpdateHotelCommonRequest(int id,string name, string location, string adress, string phoneNumber, string email, int numberOfStar)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.NumberOfStar = numberOfStar;
        }
    }
}
