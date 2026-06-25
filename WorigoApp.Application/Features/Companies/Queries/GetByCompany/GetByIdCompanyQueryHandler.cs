using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Companies.Queries.GetByCompany
{
/// <summary>
/// GetByIdCompanyQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdCompanyQueryHandler : BaseHandler, IRequestHandler<GetByIdCompanyQueryRequest, ResponseDto<GetByIdCompanyQueryResponse>>
    {
/// <summary>
/// GetByIdCompanyQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdCompanyQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdCompanyQueryResponse>> Handle(GetByIdCompanyQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.CompanyId);

            var map = mapper.Map<GetByIdCompanyQueryResponse, Company>(data);

            return new ResponseDto<GetByIdCompanyQueryResponse>().Success(map);
        }
    }
}
