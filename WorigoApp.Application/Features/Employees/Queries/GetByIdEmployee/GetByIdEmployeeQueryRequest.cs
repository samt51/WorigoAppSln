using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Employees.Queries.GetByIdEmployee
{
/// <summary>
/// GetByIdEmployeeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdEmployeeQueryRequest : IRequest<ResponseDto<GetByIdEmployeeResponse>>
    {
/// <summary>
/// GetByIdEmployeeQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdEmployeeQueryRequest(int employeeId)
        {
            this.EmployeeId = employeeId;
        }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeId { get; }
    }
}
