using MediatR;

namespace WorigoApp.Application.Features.Departments.Queries.GetAllDepartment
{
    public class GetAllDepartmentQueryRequest : IRequest<IList<GetAllDepartmentQueryResponse>>
    {
        public GetAllDepartmentQueryRequest()
        {
            
        }
    }
}
