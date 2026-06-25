using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.AddContentOfFoodByFoodId
{
/// <summary>
/// AddContentOfFoodByFoodIdHandler sınıfını temsil eder.
/// </summary>
public class AddContentOfFoodByFoodIdHandler : BaseHandler, IRequestHandler<AddContentOfFoodByFoodIdRequest, ResponseDto<AddContentOfFoodByFoodIdResponse>>
    {
        private readonly ContentOfFoodRule _contentOfFoodRule;
/// <summary>
/// AddContentOfFoodByFoodIdHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public AddContentOfFoodByFoodIdHandler(IMapper mapper, IUnitOfWork unitOfWork, ContentOfFoodRule contentOfFoodRule) : base(mapper, unitOfWork)
        {
            _contentOfFoodRule = contentOfFoodRule;
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<AddContentOfFoodByFoodIdResponse>> Handle(AddContentOfFoodByFoodIdRequest request, CancellationToken cancellationToken)
        {


            await _contentOfFoodRule.CheckFoodContentsOfFoodWithContentIdAndFoodId(request);

            var map = mapper.Map<FoodContentsOfFood, AddContentOfFoodByFoodIdRequest>(request);

            await unitOfWork.GetWriteRepository<FoodContentsOfFood>().AddAsync(map);

            await unitOfWork.SaveAsync();

            return new ResponseDto<AddContentOfFoodByFoodIdResponse>().Success();

        }
    }
}
