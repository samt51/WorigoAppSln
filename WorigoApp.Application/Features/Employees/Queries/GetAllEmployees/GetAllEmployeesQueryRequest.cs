using MediatR;

namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryRequest : IRequest<IList<GetAllEmployeesQueryResponse>>
    {
        public int HotelId { get; set; }
        public GetAllEmployeesQueryRequest(int hotelid)
        {
            this.HotelId = hotelid;
        }
    }
}
