using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hr.Performance.Commands.CreatePerformanceReview
{
/// <summary>
/// CreatePerformanceReviewCommandHandler sınıfını temsil eder.
/// </summary>
public class CreatePerformanceReviewCommandHandler : BaseHandler, IRequestHandler<CreatePerformanceReviewCommandRequest, ResponseDto<CreatePerformanceReviewCommandResponse>>
    {
/// <summary>
/// CreatePerformanceReviewCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreatePerformanceReviewCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreatePerformanceReviewCommandResponse>> Handle(CreatePerformanceReviewCommandRequest request, CancellationToken cancellationToken)
        {
            var employee = await unitOfWork.GetReadRepository<Employee>().GetAsync(
                x => x.Id == request.EmployeeId && x.HotelId == request.HotelId && !x.IsDeleted,
                include: x => x.Include(y => y.EmployeeType));

            await unitOfWork.GetReadRepository<Employee>().GetAsync(
                x => x.Id == request.ReviewerEmployeeId && x.HotelId == request.HotelId && !x.IsDeleted);

            var entity = await unitOfWork.GetWriteRepository<PerformanceReview>().AddAsync(new PerformanceReview
            {
                HotelId = request.HotelId,
                EmployeeId = request.EmployeeId,
                ReviewerEmployeeId = request.ReviewerEmployeeId,
                DepartmentId = employee.EmployeeType?.DepartmentId,
                PeriodStartDate = request.PeriodStartDate,
                PeriodEndDate = request.PeriodEndDate,
                Score = request.Score,
                Strengths = request.Strengths,
                ImprovementAreas = request.ImprovementAreas,
                ManagerNote = request.ManagerNote,
                Status = request.Status,
                ReviewDate = DateTime.UtcNow
            });

            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreatePerformanceReviewCommandResponse>().Success(new CreatePerformanceReviewCommandResponse
            {
                Id = entity.Id,
                Score = entity.Score,
                ReviewDate = entity.ReviewDate
            });
        }
    }
}
