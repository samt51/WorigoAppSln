using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.ServiceRequestRatings.Commands.CreateServiceRequestRating
{
/// <summary>
/// CreateServiceRequestRatingCommandHandler sınıfını temsil eder.
/// </summary>
public class CreateServiceRequestRatingCommandHandler : BaseHandler, IRequestHandler<CreateServiceRequestRatingCommandRequest, ResponseDto<CreateServiceRequestRatingCommandResponse>>
    {
/// <summary>
/// CreateServiceRequestRatingCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateServiceRequestRatingCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateServiceRequestRatingCommandResponse>> Handle(CreateServiceRequestRatingCommandRequest request, CancellationToken cancellationToken)
        {
            var serviceRequest = await unitOfWork.GetReadRepository<ServiceRequest>()
                .GetAsync(x => x.Id == request.ServiceRequestId && !x.IsDeleted, enableTracking: true);

            if (serviceRequest.Status != ServiceRequestStatusEnum.Completed && serviceRequest.Status != ServiceRequestStatusEnum.Closed)
            {
                throw new Exception("Tamamlanmamis servis talebi puanlanamaz.");
            }

            if (request.CustomerId.HasValue)
            {
                await unitOfWork.GetReadRepository<Customer>()
                    .GetAsync(x => x.Id == request.CustomerId.Value && !x.IsDeleted);
            }

            var isAlreadyRated = await unitOfWork.GetReadRepository<ServiceRequestRating>().FindAsync(
                x => x.ServiceRequestId == request.ServiceRequestId &&
                     x.CustomerId == request.CustomerId &&
                     !x.IsDeleted);

            if (isAlreadyRated is not null)
            {
                throw new Exception("Bu servis talebi icin daha once puanlama yapilmis.");
            }

            var rating = new ServiceRequestRating
            {
                ServiceRequestId = request.ServiceRequestId,
                CustomerId = request.CustomerId,
                SpeedScore = request.SpeedScore,
                QualityScore = request.QualityScore,
                StaffScore = request.StaffScore,
                Comment = request.Comment,
                RatedAt = DateTime.UtcNow
            };

            await unitOfWork.OpenTransactionAsync(cancellationToken);
            var createdRating = await unitOfWork.GetWriteRepository<ServiceRequestRating>().AddAsync(rating);
            await unitOfWork.SaveAsync(cancellationToken);

            if (serviceRequest.AssignedEmployeeId.HasValue)
            {
                var employee = await unitOfWork.GetReadRepository<Employee>()
                    .GetAsync(x => x.Id == serviceRequest.AssignedEmployeeId.Value && !x.IsDeleted, enableTracking: true);

                var employeeRatings = await unitOfWork.GetReadRepository<ServiceRequestRating>().GetAllAsync(
                    x => x.ServiceRequest.AssignedEmployeeId == employee.Id && !x.IsDeleted);

                var newAverage = employeeRatings.Any()
                    ? employeeRatings.Average(x => (x.SpeedScore + x.QualityScore + x.StaffScore) / 3m)
                    : (request.SpeedScore + request.QualityScore + request.StaffScore) / 3m;

                employee.AverageRating = Math.Round(newAverage, 2);
                await unitOfWork.GetWriteRepository<Employee>().UpdateAsync(employee);
                await unitOfWork.SaveAsync(cancellationToken);
            }

            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateServiceRequestRatingCommandResponse>().Success(new CreateServiceRequestRatingCommandResponse
            {
                Id = createdRating.Id,
                ServiceRequestId = createdRating.ServiceRequestId ?? 0,
                SpeedScore = createdRating.SpeedScore,
                QualityScore = createdRating.QualityScore,
                StaffScore = createdRating.StaffScore,
                RatedAt = createdRating.RatedAt
            });
        }
    }
}
