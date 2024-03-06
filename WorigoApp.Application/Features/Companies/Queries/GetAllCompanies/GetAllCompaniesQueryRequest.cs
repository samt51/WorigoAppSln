using MediatR;

namespace WorigoApp.Application.Features.Companies.Queries.GetAllCompanies
{
    public class GetAllCompaniesQueryRequest : IRequest<IList<GetAllCompaniesQueryResponse>>
    {
        public GetAllCompaniesQueryRequest()
        {
            
        }
    }
}
