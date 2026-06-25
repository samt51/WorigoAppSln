using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ImageCategories.Queries.GetByImageCategory
{
/// <summary>
/// GetByImageCategoryQueryRequest sınıfını temsil eder.
/// </summary>
public class GetByImageCategoryQueryRequest : IRequest<ResponseDto<GetByImageCategoryQueryResponse>>
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; }
/// <summary>
/// GetByImageCategoryQueryRequest sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByImageCategoryQueryRequest(int id)
        {
            this.Id = id;
        }
    }
}
