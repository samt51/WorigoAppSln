using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
    public class GetAllHotelsQueryRequest : IRequest<Response<IList<GetAllHotelsQueryResponse>>>
    {
        public int CompanyId { get; }
        public GetAllHotelsQueryRequest(int companyId)
        {
            this.CompanyId = companyId;
        }
    }
}
