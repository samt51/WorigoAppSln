using MediatR;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
    public class GetAllHotelsQueryRequest : IRequest<IList<GetAllHotelsQueryResponse>>
    {
        public int CompanyId { get; }
        public GetAllHotelsQueryRequest(int companyId)
        {
            this.CompanyId = companyId;
        }
    }
}
