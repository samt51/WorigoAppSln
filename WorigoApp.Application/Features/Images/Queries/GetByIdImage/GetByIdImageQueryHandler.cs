using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Images.Queries.GetByIdImage
{
/// <summary>
/// GetByIdImageQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdImageQueryHandler : BaseHandler, IRequestHandler<GetByIdImageQueryRequest, ResponseDto<GetByIdImageQueryResponse>>
    {
/// <summary>
/// GetByIdImageQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdImageQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdImageQueryResponse>> Handle(GetByIdImageQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Image>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var map = mapper.Map<GetByIdImageQueryResponse, Image>(data);

            return new ResponseDto<GetByIdImageQueryResponse>().Success(map);
        }
    }
}
