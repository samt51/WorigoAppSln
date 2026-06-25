using MediatR;
using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.CreateContentOfFood
{
/// <summary>
/// CreateContentOfFoodHandler sınıfını temsil eder.
/// </summary>
public class CreateContentOfFoodHandler : BaseHandler, IRequestHandler<CreateContentOfFoodRequest, ResponseDto<CreateContentOfFoodResponse>>
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ContentOfFoodRule _contentOfFoodRule;
/// <summary>
/// CreateContentOfFoodHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public CreateContentOfFoodHandler(ContentOfFoodRule contentOfFoodRule, IMapper mapper, IUnitOfWork unitOfWork, IMemoryCache memoryCache) : base(mapper, unitOfWork)
        {
            _memoryCache = memoryCache;
            this._contentOfFoodRule = contentOfFoodRule;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<CreateContentOfFoodResponse>> Handle(CreateContentOfFoodRequest request, CancellationToken cancellationToken)
        {
            await _contentOfFoodRule.IsThereRequestContentOfFoodToCache(request.Name);

            var mapData = mapper.Map<ContentsOfFood, CreateContentOfFoodRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            await unitOfWork.GetWriteRepository<ContentsOfFood>().AddAsync(mapData);

            await unitOfWork.SaveAsync();

            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateContentOfFoodResponse>().Success();
        }
    }
}
