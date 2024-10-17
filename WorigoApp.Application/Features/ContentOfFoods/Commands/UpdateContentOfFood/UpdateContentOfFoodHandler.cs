using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.ContentOfFoods.Rules;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.ContentOfFoods.Commands.UpdateContentOfFood
{
    public class UpdateContentOfFoodHandler : BaseHandler, IRequestHandler<UpdateContentOfFoodRequest, Response<UpdateContentOfFoodResponse>>
    {
        private readonly ContentOfFoodRule _contentOfFoodRule;
        public UpdateContentOfFoodHandler(IMapper mapper, IUnitOfWork unitOfWork, ContentOfFoodRule contentOfFoodRule) : base(mapper, unitOfWork)
        {
            this._contentOfFoodRule = contentOfFoodRule;
        }
        public async Task<Response<UpdateContentOfFoodResponse>> Handle(UpdateContentOfFoodRequest request, CancellationToken cancellationToken)
        {
            await _contentOfFoodRule.IsThereRequestContentOfFoodToCache(request.Name);

            var data = await unitOfWork.GetReadRepository<ContentsOfFood>().GetAsync(y => y.Id == request.Id && !y.IsDeleted);

            data.Name = request.Name;

            await unitOfWork.GetWriteRepository<ContentsOfFood>().AddAsync(data);

            await unitOfWork.SaveAsync();

            return new Response<UpdateContentOfFoodResponse>().Success();
        }
    }
}
