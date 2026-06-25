using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.UserFeature.Queries.GetByIdUser
{
/// <summary>
/// GetByIdUserQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdUserQueryHandler : BaseHandler, IRequestHandler<GetByIdUserQueryRequest, ResponseDto<GetByIdUserQueryResponse>>
    {
/// <summary>
/// GetByIdUserQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdUserQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdUserQueryResponse>> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Users>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdUserQueryResponse, Users>(data);

            return new ResponseDto<GetByIdUserQueryResponse>().Success(map);
        }
    }
}
