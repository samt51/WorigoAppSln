using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetByIdContent
{
/// <summary>
/// GetByIdContentQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdContentQueryRequest : IRequest<ResponseDto<GetByIdContentQueryResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// GetByIdContentQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdContentQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
