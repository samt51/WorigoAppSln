using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.EmployeeTypes.Commands.CreateEmployeeType
{
    public class CreateEmployeeTypeCommonHandler : BaseHandler, IRequestHandler<CreateEmployeeTypeCommonRequest, ResponseDto<CreateEmployeeTypeCommonResponse>>
    {
        public CreateEmployeeTypeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateEmployeeTypeCommonResponse>> Handle(CreateEmployeeTypeCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.DepartmentId);

            var creatMapper = mapper.Map<EmployeeType, CreateEmployeeTypeCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<EmployeeType>().AddAsync(creatMapper);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateEmployeeTypeCommonResponse>().Success();

        }
    }
}
