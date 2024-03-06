using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommonRequest : IRequest<Response<CreateDepartmentCommonResponse>>
    {
        public string Name { get; }
        public int HotelId { get; }
        public CreateDepartmentCommonRequest(string name, int hotelid)
        {
            this.Name = name;
            this.HotelId = hotelid;
        }
    }
}
