using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Queries.GetAllHotels
{
/// <summary>
/// GetAllHotelsQueryHandler sınıfını temsil eder.
/// </summary>
public class GetAllHotelsQueryHandler : BaseHandler, IRequestHandler<GetAllHotelsQueryRequest, IList<GetAllHotelsQueryResponse>>
    {
/// <summary>
/// GetAllHotelsQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetAllHotelsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<IList<GetAllHotelsQueryResponse>> Handle(GetAllHotelsQueryRequest request, CancellationToken cancellationToken)
        {
            var getHotels = await unitOfWork.GetReadRepository<Hotel>().GetAllAsync(x => x.Companyid == request.CompanyId && !x.IsDeleted);

            return mapper.Map<GetAllHotelsQueryResponse, Hotel>(getHotels);
        }
    }
}
