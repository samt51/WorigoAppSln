using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Queries.GetAllDepartment
{
    public class GetAllDepartmentQueryRequest : IRequest<Response<IList<GetAllDepartmentQueryResponse>>>
    {
        public GetAllDepartmentQueryRequest()
        {
            
        }
    }
}
