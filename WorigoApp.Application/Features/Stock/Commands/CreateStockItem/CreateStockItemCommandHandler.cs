using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockItem
{
    public class CreateStockItemCommandHandler : BaseHandler, IRequestHandler<CreateStockItemCommandRequest, ResponseDto<CreateStockItemCommandResponse>>
    {
        public CreateStockItemCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateStockItemCommandResponse>> Handle(CreateStockItemCommandRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && x.IsActive && !x.IsDeleted);

            if (request.DepartmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId.Value && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);
            }

            var existing = await unitOfWork.GetReadRepository<StockItem>().FindAsync(
                x => x.HotelId == request.HotelId && x.Code == request.Code && !x.IsDeleted);

            if (existing is not null)
            {
                return new ResponseDto<CreateStockItemCommandResponse>().Fail(new List<string> { "Ayni stok koduna sahip bir kayit zaten mevcut." }, 400);
            }

            var entity = new StockItem
            {
                HotelId = request.HotelId,
                DepartmentId = request.DepartmentId,
                Code = request.Code,
                Name = request.Name,
                Unit = request.Unit,
                CurrentQuantity = request.CurrentQuantity,
                MinimumQuantity = request.MinimumQuantity,
                LastPurchasePrice = request.LastPurchasePrice,
                AverageUnitCost = request.AverageUnitCost,
                IsCritical = request.IsCritical,
                Description = request.Description
            };

            var created = await unitOfWork.GetWriteRepository<StockItem>().AddAsync(entity);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<CreateStockItemCommandResponse>().Success(new CreateStockItemCommandResponse
            {
                Id = created.Id,
                Name = created.Name,
                CurrentQuantity = created.CurrentQuantity,
                MinimumQuantity = created.MinimumQuantity
            });
        }
    }
}
