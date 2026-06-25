using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Queries.GetByIdContent
{
/// <summary>
/// GetByIdContentQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdContentQueryHandler : BaseHandler, IRequestHandler<GetByIdContentQueryRequest, ResponseDto<GetByIdContentQueryResponse>>
    {
/// <summary>
/// GetByIdContentQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdContentQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdContentQueryResponse>> Handle(GetByIdContentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAsync(x => !x.IsDeleted && x.Id == request.Id);

            var map = mapper.Map<GetByIdContentQueryResponse, ContentsOfFood>(data);

            return new ResponseDto<GetByIdContentQueryResponse>().Success(map);
        }
    }
}
