using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockMovement
{
    public class CreateStockMovementCommandHandler : BaseHandler, IRequestHandler<CreateStockMovementCommandRequest, ResponseDto<CreateStockMovementCommandResponse>>
    {
        public CreateStockMovementCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateStockMovementCommandResponse>> Handle(CreateStockMovementCommandRequest request, CancellationToken cancellationToken)
        {
            var stockItem = await unitOfWork.GetReadRepository<StockItem>().GetAsync(
                x => x.Id == request.StockItemId && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);

            if (request.DepartmentId.HasValue)
            {
                await unitOfWork.GetReadRepository<Department>().GetAsync(x => x.Id == request.DepartmentId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            if (request.EmployeeId.HasValue)
            {
                await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.EmployeeId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var signedQuantity = request.MovementType is StockMovementTypeEnum.PurchaseIn or StockMovementTypeEnum.AdjustmentIn or StockMovementTypeEnum.ReturnIn
                ? request.Quantity
                : -request.Quantity;

            var newQuantity = stockItem.CurrentQuantity + signedQuantity;
            if (newQuantity < 0)
            {
                return new ResponseDto<CreateStockMovementCommandResponse>().Fail(new List<string> { "Stok miktari sifirin altina dusurulemez." }, 400);
            }

            var totalAmount = request.Quantity * request.UnitPrice;
            var previousQuantity = stockItem.CurrentQuantity;

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            stockItem.CurrentQuantity = newQuantity;

            if (request.MovementType == StockMovementTypeEnum.PurchaseIn)
            {
                stockItem.LastPurchasePrice = request.UnitPrice;

                var totalExistingCost = stockItem.AverageUnitCost * Math.Max(previousQuantity, 0);
                var totalNewCost = request.Quantity * request.UnitPrice;
                var divisor = Math.Max(previousQuantity + request.Quantity, 1);
                stockItem.AverageUnitCost = (totalExistingCost + totalNewCost) / divisor;
            }

            await unitOfWork.GetWriteRepository<StockItem>().UpdateAsync(stockItem);

            var movement = await unitOfWork.GetWriteRepository<StockMovement>().AddAsync(new StockMovement
            {
                HotelId = request.HotelId,
                StockItemId = request.StockItemId,
                DepartmentId = request.DepartmentId,
                EmployeeId = request.EmployeeId,
                MovementType = request.MovementType,
                Quantity = request.Quantity,
                UnitPrice = request.UnitPrice,
                TotalAmount = totalAmount,
                Reason = request.Reason,
                ReferenceType = request.ReferenceType,
                ReferenceId = request.ReferenceId,
                OccurredAt = request.OccurredAt ?? DateTime.UtcNow
            });

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateStockMovementCommandResponse>().Success(new CreateStockMovementCommandResponse
            {
                Id = movement.Id,
                CurrentQuantity = stockItem.CurrentQuantity,
                TotalAmount = movement.TotalAmount
            });
        }
    }
}
