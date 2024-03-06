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
            var hoteIsControll = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId);

            if (hoteIsControll is null)
            {
                return new Response<CreateDepartmentCommonResponse>().Fail(new CreateDepartmentCommonResponse(), "Hotel is Null", 200);
            }
            var map = mapper.Map<Department, CreateDepartmentCommonRequest>(request);

            unitOfWork.OpenTransaction();

            var saveEntity = await unitOfWork.GetWriteRepository<Department>().AddAsync(map);

            if (await unitOfWork.SaveAsync() > 0)
            {
                unitOfWork.Commit();
                return new Response<CreateDepartmentCommonResponse>().Success();
            }
            return new Response<CreateDepartmentCommonResponse>().Fail(new CreateDepartmentCommonResponse(), "", 400);

        }
    }
}
