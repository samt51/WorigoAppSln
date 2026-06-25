using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
/// <summary>
/// GetAllEmployeeTypesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllEmployeeTypesQueryRequest : IRequest<ResponseDto<IList<GetAllEmployeeTypesQueryResponse>>>
    {
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int DepartmentId { get; }
/// <summary>
/// GetAllEmployeeTypesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllEmployeeTypesQueryRequest(int departmentId)
        {
            this.DepartmentId = departmentId;
        }
    }
}
