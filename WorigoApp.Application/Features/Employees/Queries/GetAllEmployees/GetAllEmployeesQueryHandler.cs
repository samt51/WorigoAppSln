using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Queries.GetAllEmployees
{
    public class GetAllEmployeesQueryHandler : BaseHandler, IRequestHandler<GetAllEmployeesQueryRequest, Response<IList<GetAllEmployeesQueryResponse>>>
    {
        public GetAllEmployeesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<IList<GetAllEmployeesQueryResponse>>> Handle(GetAllEmployeesQueryRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await unitOfWork.GetReadRepository<Employee>().GetAllAsync(x => x.HotelId == request.HotelId && !x.IsDeleted);

            var map = mapper.Map<GetAllEmployeesQueryResponse, Employee>(employeeList);

            return new Response<IList<GetAllEmployeesQueryResponse>>().Success(map);
        }
    }
}
