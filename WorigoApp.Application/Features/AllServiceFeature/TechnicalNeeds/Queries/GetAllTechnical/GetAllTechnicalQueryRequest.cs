using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.AllServiceFeature.TechnicalNeeds.Queries.GetAllTechnical
{
    public class GetAllTechnicalQueryRequest : IRequest<Response<IList<GetAllTechnicalQueryResponse>>>
    {
        public GetAllTechnicalQueryRequest()
        {
            
        }
    }
}
