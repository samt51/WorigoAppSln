using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Services.Commands.ToggleServiceCatalogStatus
{
/// <summary>
/// ToggleServiceCatalogStatusCommandHandler sınıfını temsil eder.
/// </summary>
public class ToggleServiceCatalogStatusCommandHandler : BaseHandler, IRequestHandler<ToggleServiceCatalogStatusCommandRequest, ResponseDto<ToggleServiceCatalogStatusCommandResponse>>
    {
/// <summary>
/// ToggleServiceCatalogStatusCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public ToggleServiceCatalogStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<ToggleServiceCatalogStatusCommandResponse>> Handle(ToggleServiceCatalogStatusCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var definition = await unitOfWork.GetReadRepository<ServiceDefinition>()
                .GetAsync(
                    x => x.Id == request.ServiceCatalogItemId &&
                         x.HotelId == request.HotelId &&
                         x.ServiceType == request.ServiceType &&
                         !x.IsDeleted,
                    enableTracking: true);

            definition.IsActive = request.IsActive;
            await unitOfWork.GetWriteRepository<ServiceDefinition>().UpdateAsync(definition);
            await unitOfWork.SaveAsync(cancellationToken);

            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<ToggleServiceCatalogStatusCommandResponse>().Success(new ToggleServiceCatalogStatusCommandResponse
            {
                ServiceType = request.ServiceType,
                ServiceCatalogItemId = request.ServiceCatalogItemId,
                IsActive = request.IsActive
            });
        }
    }
}
