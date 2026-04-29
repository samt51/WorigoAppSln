using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Companies.Queries.GetAllCompanies
{
    public class GetAllCompaniesQueryRequest : IRequest<ResponseDto<IList<GetAllCompaniesQueryResponse>>>
    {
        public GetAllCompaniesQueryRequest()
        {

        }
    }
}
