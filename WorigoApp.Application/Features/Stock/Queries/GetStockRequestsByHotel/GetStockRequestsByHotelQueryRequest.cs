using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByHotel
{
    public class GetStockRequestsByHotelQueryRequest : IRequest<ResponseDto<IList<GetStockRequestsByHotelQueryResponse>>>
    {
        public int HotelId { get; set; }
    }
}
