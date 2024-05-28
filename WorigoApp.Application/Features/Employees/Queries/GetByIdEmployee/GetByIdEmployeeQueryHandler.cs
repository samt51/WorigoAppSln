using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Queries.GetByIdEmployee
{
    public class GetByIdEmployeeQueryHandler : BaseHandler, IRequestHandler<GetByIdEmployeeQueryRequest, Response<GetByIdEmployeeResponse>>
    {
        public GetByIdEmployeeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<GetByIdEmployeeResponse>> Handle(GetByIdEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.EmployeeId && !x.IsDeleted);

            var map = mapper.Map<GetByIdEmployeeResponse, Employee>(data);

            return new Response<GetByIdEmployeeResponse>().Success(map);
        }
    }
}
