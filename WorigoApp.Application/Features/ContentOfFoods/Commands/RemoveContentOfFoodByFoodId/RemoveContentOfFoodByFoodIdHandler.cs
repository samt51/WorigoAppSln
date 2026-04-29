using MediatR;
using Microsoft.AspNetCore.Server.HttpSys;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites.IntermediateTables;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.RemoveContentOfFoodByFoodId
{
    public class RemoveContentOfFoodByFoodIdHandler : BaseHandler, IRequestHandler<RemoveContentOfFoodByFoodIdRequest, ResponseDto<RemoveContentOfFoodByFoodIdResponse>>
    {
        private readonly ContentOfFoodRule _contentOfFoodRule;
        public RemoveContentOfFoodByFoodIdHandler(ContentOfFoodRule contentOfFoodRule, IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
            _contentOfFoodRule = contentOfFoodRule;
        }

        public async Task<ResponseDto<RemoveContentOfFoodByFoodIdResponse>> Handle(RemoveContentOfFoodByFoodIdRequest request, CancellationToken cancellationToken)
        {
            await _contentOfFoodRule.CheckFoodContentsOfFoodWithContentIdAndFoodId(request.FoodId, request.ContentsOfFoodId);

            var data = await unitOfWork.GetReadRepository<FoodContentsOfFood>().GetAsync(x => x.FoodId == request.FoodId && x.ContentsOfFoodId == request.ContentsOfFoodId);

            data.IsActive = true;

            await unitOfWork.GetWriteRepository<FoodContentsOfFood>().UpdateAsync(data);

            await unitOfWork.SaveAsync();

            return new ResponseDto<RemoveContentOfFoodByFoodIdResponse>().Success();
        }
    }
}
