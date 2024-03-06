using WorigoApp.Application.Features.Hotels.Queries.GetAllHotels;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServicesQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int HotelId { get; set; }
        public GetAllHotelsQueryResponse Hotel { get; set; }
    }
}
