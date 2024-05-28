using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Queries.GetByCompany
{
    public class GetByIdCompanyQueryRequest : IRequest<Response<GetByIdCompanyQueryResponse>>
    {
        public GetByIdCompanyQueryRequest(int companyId)
        {
            this.CompanyId = companyId;
        }
        public int CompanyId { get; }
    }
}
