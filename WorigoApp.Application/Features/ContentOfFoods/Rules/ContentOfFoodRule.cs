using Microsoft.Extensions.Caching.Memory;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Commands.AddContentOfFoodByFoodId;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Application.Features.ContentOfFoods.Rules
{
/// <summary>
/// ContentOfFoodRule sınıfını temsil eder.
/// </summary>
public class ContentOfFoodRule : BaseRules
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IUnitOfWork _unitOfWork;
/// <summary>
/// ContentOfFoodRule sınıfının yeni bir örneğini başlatır.
/// </summary>
public ContentOfFoodRule(IMemoryCache memoryCache, IUnitOfWork unitOfWork)
        {
            _memoryCache = memoryCache;
            _unitOfWork = unitOfWork;
        }
/// <summary>
/// IsThereRequestContentOfFoodToCache işlemini gerçekleştirir.
/// </summary>
public async Task IsThereRequestContentOfFoodToCache(string content)
        {
            var cacheData = _memoryCache.Get<List<ContentsOfFood>>("contentsOfFood").Select(y => new ContentsOfFood
            {
                Name = y.Name.Trim().ToLower(),
            });

            if (cacheData == null)
            {
                cacheData = await _unitOfWork.GetReadRepository<ContentsOfFood>().GetAllAsync(y => !y.IsDeleted, selector: X => new ContentsOfFood
                {
                    Name = X.Name.Trim().ToLower(),
                });
            }

            if (cacheData.Any(x => x.Name == content.Trim().ToLower()))
            {
                throw new Exception($"{content} zaten mevcut");
            }
        }
/// <summary>
/// CheckFoodContentsOfFoodWithContentIdAndFoodId işlemini gerçekleştirir.
/// </summary>
public async Task CheckFoodContentsOfFoodWithContentIdAndFoodId(AddContentOfFoodByFoodIdRequest request)
        {
            await _unitOfWork.GetReadRepository<Food>().GetAsync(x => !x.IsDeleted && x.Id == request.FoodId);

            await _unitOfWork.GetReadRepository<ContentsOfFood>().GetAsync(x => x.Id == request.ContentsOfFoodId && !x.IsDeleted);

            var dataIsNull = await _unitOfWork.GetReadRepository<FoodContentsOfFood>().FindAsync(x => x.FoodId == request.FoodId && x.ContentsOfFoodId == request.ContentsOfFoodId);

            if (dataIsNull is not null)
            {
                throw new Exception("İçerik ürünü mevcut üründe var ekleme işlemi başarısız.");
            }
        }
/// <summary>
/// CheckFoodContentsOfFoodWithContentIdAndFoodId işlemini gerçekleştirir.
/// </summary>
public async Task CheckFoodContentsOfFoodWithContentIdAndFoodId(int foodId, int contentsOfFoodId)
        {
            await _unitOfWork.GetReadRepository<Food>().GetAsync(x => !x.IsDeleted && x.Id == foodId);

            await _unitOfWork.GetReadRepository<ContentsOfFood>().GetAsync(x => x.Id == contentsOfFoodId && !x.IsDeleted);

            await _unitOfWork.GetReadRepository<FoodContentsOfFood>().GetAsync(x => x.FoodId == foodId && x.ContentsOfFoodId == contentsOfFoodId);

        }
    }
}
