using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Departments.Commands.CreateDepartment
{
    public class CreateDepartmentCommonHandler : BaseHandler, IRequestHandler<CreateDepartmentCommonRequest, Response<CreateDepartmentCommonResponse>>
    {
        public CreateDepartmentCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateDepartmentCommonResponse>> Handle(CreateDepartmentCommonRequest request, CancellationToken cancellationToken)
        {
            var hoteIsControll = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && !x.IsDeleted);

            var map = mapper.Map<EmployeeType, CreateDepartmentCommonRequest>(request);

            unitOfWork.OpenTransaction();

            var saveEntity = await unitOfWork.GetWriteRepository<EmployeeType>().AddAsync(map);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new Response<CreateDepartmentCommonResponse>().Success();
        }
    }
}
