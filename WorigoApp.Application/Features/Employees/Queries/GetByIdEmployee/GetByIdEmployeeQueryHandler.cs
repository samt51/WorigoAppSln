using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Queries.GetByIdEmployee
{
/// <summary>
/// GetByIdEmployeeQueryHandler sınıfını temsil eder.
/// </summary>
public class GetByIdEmployeeQueryHandler : BaseHandler, IRequestHandler<GetByIdEmployeeQueryRequest, ResponseDto<GetByIdEmployeeResponse>>
    {
/// <summary>
/// GetByIdEmployeeQueryHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public GetByIdEmployeeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<GetByIdEmployeeResponse>> Handle(GetByIdEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.EmployeeId && !x.IsDeleted);

            var map = mapper.Map<GetByIdEmployeeResponse, Employee>(data);

            return new ResponseDto<GetByIdEmployeeResponse>().Success(map);
        }
    }
}
