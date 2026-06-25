using MediatR;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
/// <summary>
/// GetAllHotelsQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllHotelsQueryRequest : IRequest<IList<GetAllHotelsQueryResponse>>
    {
/// <summary>
/// CompanyId değerini alır veya ayarlar.
/// </summary>
public int CompanyId { get; }
/// <summary>
/// GetAllHotelsQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllHotelsQueryRequest(int companyId)
        {
            this.CompanyId = companyId;
        }
    }
}
