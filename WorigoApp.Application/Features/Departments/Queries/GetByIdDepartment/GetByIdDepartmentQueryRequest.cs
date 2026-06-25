using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Departments.Queries.GetByIdDepartment
{
/// <summary>
/// GetByIdDepartmentQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdDepartmentQueryRequest : IRequest<ResponseDto<GetByIdDepartmentQueryResponse>>
    {
/// <summary>
/// GetByIdDepartmentQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdDepartmentQueryRequest(int departmentId)
        {
            this.DepartmentId = departmentId;
        }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; }
    }
}
