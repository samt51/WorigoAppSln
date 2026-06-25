using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Queries.GetByCompany
{
/// <summary>
/// GetByIdCompanyQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdCompanyQueryRequest : IRequest<ResponseDto<GetByIdCompanyQueryResponse>>
    {
/// <summary>
/// GetByIdCompanyQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdCompanyQueryRequest(int companyId)
        {
            this.CompanyId = companyId;
        }
/// <summary>
/// CompanyId değerini alır veya ayarlar.
/// </summary>
public int CompanyId { get; }
    }
}
