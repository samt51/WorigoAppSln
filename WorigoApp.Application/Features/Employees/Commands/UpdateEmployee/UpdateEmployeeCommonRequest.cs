using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;

namespace WorigoApp.Application.Features.Employees.Commands.UpdateEmployee
{
    public class UpdateEmployeeCommonRequest : IRequest<Response<UpdateEmployeeCommonResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeDetailRequestDto employeeDetailRequest { get; set; }
    }
}
