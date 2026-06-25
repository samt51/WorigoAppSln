using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.UpdateContentOfFood
{
/// <summary>
/// UpdateContentOfFoodHandler sınıfını temsil eder.
/// </summary>
public class UpdateContentOfFoodHandler : BaseHandler, IRequestHandler<UpdateContentOfFoodRequest, ResponseDto<UpdateContentOfFoodResponse>>
    {
        private readonly ContentOfFoodRule _contentOfFoodRule;
/// <summary>
/// UpdateContentOfFoodHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateContentOfFoodHandler(IMapper mapper, IUnitOfWork unitOfWork, ContentOfFoodRule contentOfFoodRule) : base(mapper, unitOfWork)
        {
            this._contentOfFoodRule = contentOfFoodRule;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateContentOfFoodResponse>> Handle(UpdateContentOfFoodRequest request, CancellationToken cancellationToken)
        {
            await _contentOfFoodRule.IsThereRequestContentOfFoodToCache(request.Name);

            var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAsync(y => y.Id == request.Id && !y.IsDeleted);

            data.Name = request.Name;

            await unitOfWork.GetWriteRepository<ContentsOfFood>().AddAsync(data);

            await unitOfWork.SaveAsync();

            return new ResponseDto<UpdateContentOfFoodResponse>().Success();
        }
    }
}
