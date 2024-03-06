using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Queries.GetAllEmployeeTypes
{
    public class GetAllEmployeeTypesQueryHandler : BaseHandler, IRequestHandler<GetAllEmployeeTypesQueryRequest, IList<GetAllEmployeeTypesQueryResponse>>
    {
        public GetAllEmployeeTypesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IList<GetAllEmployeeTypesQueryResponse>> Handle(GetAllEmployeeTypesQueryRequest request, CancellationToken cancellationToken)
        {
            var employeeList = await unitOfWork.GetReadRepository<EmployeeType>().GetAllAsync();

            return mapper.Map<GetAllEmployeeTypesQueryResponse, EmployeeType>(employeeList);
        }
    }
}
