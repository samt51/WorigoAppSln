using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetByIdEmployeeType
{
/// <summary>
/// GetByIdEmployeeTypeQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdEmployeeTypeQueryRequest : IRequest<ResponseDto<GetByIdEmployeeTypeQueryResponse>>
    {
/// <summary>
/// GetByIdEmployeeTypeQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdEmployeeTypeQueryRequest(int employeeTypeId)
        {
            this.EmployeeTypeId = employeeTypeId;
        }
/// <summary>
/// EmployeeTypeId değerini alır veya ayarlar.
/// </summary>
public int EmployeeTypeId { get; }
    }
}
