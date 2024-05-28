using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel
{
    public class GetByIdHotelQueryRequest : IRequest<Response<GetByIdHotelQueryResponse>>
    {
        public int HotelId { get; }
    }
}
