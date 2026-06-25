using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.Images.Queries.GetByIdImage
{
/// <summary>
/// GetByIdImageQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdImageQueryRequest : IRequest<ResponseDto<GetByIdImageQueryResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// GetByIdImageQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdImageQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
