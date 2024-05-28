namespace WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel
{
    public class GetByIdHotelQueryResponse
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
