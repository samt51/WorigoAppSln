using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Queries.GetAllDepartment
{
/// <summary>
/// GetAllDepartmentQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllDepartmentQueryRequest : IRequest<ResponseDto<IList<GetAllDepartmentQueryResponse>>>
    {
/// <summary>
/// GetAllDepartmentQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllDepartmentQueryRequest()
        {
            
        }
    }
}
