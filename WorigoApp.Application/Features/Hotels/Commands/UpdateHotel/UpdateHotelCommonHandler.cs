using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Hotels.Commands.UpdateHotel
{
/// <summary>
/// UpdateHotelCommonHandler sınıfını temsil eder.
/// </summary>
public class UpdateHotelCommonHandler : BaseHandler, IRequestHandler<UpdateHotelCommonRequest, ResponseDto<UpdateHotelCommonResponse>>
    {
/// <summary>
/// UpdateHotelCommonHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateHotelCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateHotelCommonResponse>> Handle(UpdateHotelCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);

            var mapEntity = mapper.Map<Hotel, UpdateHotelCommonRequest>(request);

            await unitOfWork.GetWriteRepository<Hotel>().UpdateAsync(mapEntity);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<UpdateHotelCommonResponse>().Success();

        }
    }
}
