using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Queries.GetByIdDepartment
{
    public class GetByIdDepartmentQueryRequest : IRequest<Response<GetByIdDepartmentQueryResponse>>
    {
        public GetByIdDepartmentQueryRequest(int departmentId)
        {
            this.DepartmentId = departmentId;
        }
        public int DepartmentId { get; }
    }
}
