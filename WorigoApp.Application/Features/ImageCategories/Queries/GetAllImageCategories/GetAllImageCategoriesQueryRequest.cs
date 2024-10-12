using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetAllImageCategories
{
    public class GetAllImageCategoriesQueryRequest : IRequest<Response<IList<GetAllImageCategoriesQueryResponse>>>
    {
        public int HotelId { get; set; }
        public GetAllImageCategoriesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
