using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetByIdEmployeeType
{
    public class GetByIdEmployeeTypeQueryRequest : IRequest<ResponseDto<GetByIdEmployeeTypeQueryResponse>>
    {
        public GetByIdEmployeeTypeQueryRequest(int employeeTypeId)
        {
            this.EmployeeTypeId = employeeTypeId;
        }
        public int EmployeeTypeId { get; }
    }
}
