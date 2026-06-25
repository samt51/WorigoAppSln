using MediatR;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContent
{
/// <summary>
/// GetAllContentQueryRequest sınıfını temsil eder.
/// </summary>
public class GetAllContentQueryRequest : IRequest<ResponseDto<IList<GetAllContentQueryResponse>>>
    {
    }
}
