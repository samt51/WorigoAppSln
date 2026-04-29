using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.AllServiceFeature.TechnicalNeeds.Queries.GetAllTechnical
{
    public class GetAllTechnicalQueryRequest : IRequest<ResponseDto<IList<GetAllTechnicalQueryResponse>>>
    {
        public GetAllTechnicalQueryRequest()
        {
            
        }
    }
}
