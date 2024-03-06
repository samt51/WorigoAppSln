using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;

namespace WorigoApp.Application.Features.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommonRequest : IRequest<Response<CreateEmployeeCommonResponse>>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public int EmployeeTypeId { get; set; }
        public int HotelId { get; set; }
        public EmployeeDetailRequestDto employeeDetailRequest { get; set; }
    }
}
