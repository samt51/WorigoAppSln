using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.UserFeature.Queries.GetByIdUser
{
/// <summary>
/// GetByIdUserQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByIdUserQueryRequest : IRequest<ResponseDto<GetByIdUserQueryResponse>>
    {
/// <summary>
/// GetByIdUserQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdUserQueryRequest(int id)
        {

            Id = id;

        }
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }

    }
}

