using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Employees.Dto;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommonHandler : BaseHandler, IRequestHandler<CreateEmployeeCommonRequest, Response<CreateEmployeeCommonResponse>>
    {
        public CreateEmployeeCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<Response<CreateEmployeeCommonResponse>> Handle(CreateEmployeeCommonRequest request, CancellationToken cancellationToken)
        {
            var employeeTypeIsControll = await unitOfWork.GetReadRepository<EmployeeType>().GetAsync(x => x.Id == request.EmployeeTypeId);

            if (employeeTypeIsControll == null)
            {
                return new Response<CreateEmployeeCommonResponse>().Fail(new CreateEmployeeCommonResponse(), "EmployeeType is Undifined", 400);
            }

            var hotelId = await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId);

            if (hotelId == null)
            {
                return new Response<CreateEmployeeCommonResponse>().Fail(new CreateEmployeeCommonResponse(), "Hotel Is Undifined", 400);
            }

            var employeeMap = mapper.Map<Employee, CreateEmployeeCommonRequest>(request);

            unitOfWork.OpenTransaction();
            var saveEntity = await unitOfWork.GetWriteRepository<Employee>().AddAsync(employeeMap);

            if (await unitOfWork.SaveAsync() > 0)
            {
                var employeeDetailMap = mapper.Map<EmployeeDetail, EmployeeDetailRequestDto>(request.employeeDetailRequest);

                employeeDetailMap.EmployeeId = saveEntity.Id;

                var saveEmployeeDetail = await unitOfWork.GetWriteRepository<EmployeeDetail>().AddAsync(employeeDetailMap);

                if (await unitOfWork.SaveAsync() > 0)
                {
                    unitOfWork.Commit();
                    return new Response<CreateEmployeeCommonResponse>().Success();
                }
            }
            return new Response<CreateEmployeeCommonResponse>().Fail(new CreateEmployeeCommonResponse(), "Error", 400);

        }
    }
}
