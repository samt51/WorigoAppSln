using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Stock.Queries.GetStockRequestsByManager
{
/// <summary>
/// GetStockRequestsByManagerQueryRequest sınıfını temsil eder.
/// </summary>
public class GetStockRequestsByManagerQueryRequest : IRequest<ResponseDto<IList<GetStockRequestsByManagerQueryResponse>>>
    {
/// <summary>
/// ManagerEmployeeId değerini alır veya ayarlar.
/// </summary>
public int ManagerEmployeeId { get; set; }
    }
}
