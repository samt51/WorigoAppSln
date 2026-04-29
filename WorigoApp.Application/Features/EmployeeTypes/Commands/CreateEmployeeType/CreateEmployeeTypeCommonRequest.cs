using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType
{
    public class CreateEmployeeTypeCommonRequest : IRequest<ResponseDto<CreateEmployeeTypeCommonResponse>>
    {
        public string Name { get; }
        public int DepartmentId { get; }
        public CreateEmployeeTypeCommonRequest(string name, int departmentId)
        {
            this.Name = name;
            this.DepartmentId = departmentId;
        }
    }
}
