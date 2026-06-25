using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Queries.GetAllCompanies
{
/// <summary>
/// GetAllCompaniesQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllCompaniesQueryRequest : IRequest<ResponseDto<IList<GetAllCompaniesQueryResponse>>>
    {
/// <summary>
/// GetAllCompaniesQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllCompaniesQueryRequest()
        {

        }
    }
}
