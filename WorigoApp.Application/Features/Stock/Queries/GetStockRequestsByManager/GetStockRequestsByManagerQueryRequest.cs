using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByManager
{
    public class GetStockRequestsByManagerQueryRequest : IRequest<ResponseDto<IList<GetStockRequestsByManagerQueryResponse>>>
    {
        public int ManagerEmployeeId { get; set; }
    }
}
