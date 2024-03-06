using MediatR;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetAllImageCategories
{
    public class GetAllImageCategoriesQueryRequest : IRequest<IList<GetAllImageCategoriesQueryResponse>>
    {
        public int HotelId { get; set; }
        public GetAllImageCategoriesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
