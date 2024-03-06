using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
    public class GetAllHotelsQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int NumberOfStar { get; set; }
        public int Companyid { get; set; }
    }
}
