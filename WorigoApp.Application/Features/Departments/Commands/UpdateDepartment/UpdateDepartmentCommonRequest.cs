using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Commands.UpdateDepartment
{
    public class UpdateDepartmentCommonRequest : IRequest<ResponseDto<UpdateDepartmentCommonResponse>>
    {
        public UpdateDepartmentCommonRequest(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; }
        public string Name { get; }
    }
}
