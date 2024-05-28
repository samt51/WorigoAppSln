using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Employees.Queries.GetByIdEmployee
{
    public class GetByIdEmployeeQueryRequest : IRequest<Response<GetByIdEmployeeResponse>>
    {
        public GetByIdEmployeeQueryRequest(int employeeId)
        {
            this.EmployeeId = employeeId;
        }
        public int EmployeeId { get; }
    }
}
