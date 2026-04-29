using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel
{
    public class GetByIdHotelQueryRequest : IRequest<ResponseDto<GetByIdHotelQueryResponse>>
    {
        public int HotelId { get; }
    }
}
