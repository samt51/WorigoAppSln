using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.UpdateEmployeeType
{
    public class UpdateEmployeeTypeCommonRequest : IRequest<ResponseDto<UpdateEmployeeTypeCommonResponse>>
    {
        public UpdateEmployeeTypeCommonRequest(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public int Id { get; }
        public string Name { get; }
    }
}
