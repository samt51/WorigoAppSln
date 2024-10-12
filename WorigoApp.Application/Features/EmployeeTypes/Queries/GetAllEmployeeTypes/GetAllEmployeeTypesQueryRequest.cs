using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
    public class GetAllEmployeeTypesQueryRequest : IRequest<Response<IList<GetAllEmployeeTypesQueryResponse>>>
    {
        public int DepartmentId { get; }
        public GetAllEmployeeTypesQueryRequest(int departmentId)
        {
            this.DepartmentId = departmentId;
        }
    }
}
