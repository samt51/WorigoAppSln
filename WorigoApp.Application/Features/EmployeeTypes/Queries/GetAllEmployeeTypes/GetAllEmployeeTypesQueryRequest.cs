using MediatR;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
    public class GetAllEmployeeTypesQueryRequest : IRequest<IList<GetAllEmployeeTypesQueryResponse>>
    {
        public int DepartmentId { get; }
        public GetAllEmployeeTypesQueryRequest(int departmentId)
        {
            this.DepartmentId = departmentId;
        }
    }
}
