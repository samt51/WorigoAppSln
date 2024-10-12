using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryRequest : IRequest<Response<IList<GetAllEmployeesQueryResponse>>>
    {
        public int HotelId { get; set; }
        public GetAllEmployeesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
