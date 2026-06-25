using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetAllContent
{
/// <summary>
/// GetAllContentQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllContentQueryHandler : BaseHandler, IRequestHandler<GetAllContentQueryRequest, ResponseDto<IList<GetAllContentQueryResponse>>>
    {
/// <summary>
/// GetAllContentQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllContentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<IList<GetAllContentQueryResponse>>> Handle(GetAllContentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAllAsync(x => !x.IsDeleted);

            var map = mapper.Map<GetAllContentQueryResponse, ContentsOfFood>(data);

            return new ResponseDto<IList<GetAllContentQueryResponse>>().Success(map);
        }
    }
}
