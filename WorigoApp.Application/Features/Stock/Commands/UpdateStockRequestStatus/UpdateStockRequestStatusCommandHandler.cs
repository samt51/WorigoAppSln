using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;

namespace WorigoApp.Application.Features.Stock.Commands.UpdateStockRequestStatus
{
/// <summary>
/// UpdateStockRequestStatusCommandHandler sınıfını temsil eder.
/// </summary>
public class UpdateStockRequestStatusCommandHandler : BaseHandler, IRequestHandler<UpdateStockRequestStatusCommandRequest, ResponseDto<UpdateStockRequestStatusCommandResponse>>
    {
/// <summary>
/// UpdateStockRequestStatusCommandHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
public UpdateStockRequestStatusCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }
/// <summary>
/// Handle işlemini gerçekleştirir.
/// </summary>
public async Task<ResponseDto<UpdateStockRequestStatusCommandResponse>> Handle(UpdateStockRequestStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var currentUser = await unitOfWork.GetReadRepository<Users>().GetAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(u => u.Employee).ThenInclude(e => e.EmployeeType));

            if (currentUser == null)
            {
                return new ResponseDto<UpdateStockRequestStatusCommandResponse>().Fail(new List<string> { "Kullanıcı bulunamadı." }, 401);
            }

            bool isSystemAdmin = currentUser.RoleId == 1;
            bool isHotelAdmin = currentUser.RoleId == 2;
            bool isPurchasingManager = currentUser.RoleId == 8;
            bool isDepartmentManager = currentUser.RoleId == 4;

            var stockRequest = await unitOfWork.GetReadRepository<StockRequest>().GetAsync(
                x => x.Id == request.StockRequestId && !x.IsDeleted,
                include: x => x.Include(y => y.Items));

            if (stockRequest == null)
            {
                return new ResponseDto<UpdateStockRequestStatusCommandResponse>().Fail(new List<string> { "Stok talebi bulunamadı." }, 404);
            }

            if (!isSystemAdmin && currentUser.Employee != null && stockRequest.HotelId != currentUser.Employee.HotelId)
            {
                return new ResponseDto<UpdateStockRequestStatusCommandResponse>().Fail(new List<string> { "Bu oteldeki stok talebine müdahale etme yetkiniz yok." }, 403);
            }

            bool canManage = isSystemAdmin || isHotelAdmin || isPurchasingManager || 
                             (isDepartmentManager && currentUser.Employee != null && stockRequest.DepartmentId == currentUser.Employee.EmployeeType?.DepartmentId);

            if (!canManage)
            {
                return new ResponseDto<UpdateStockRequestStatusCommandResponse>().Fail(new List<string> { "Bu stok talebini güncelleme yetkiniz bulunmamaktadır." }, 403);
            }

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            stockRequest.Status = request.Status;
            stockRequest.ManagerNote = request.ManagerNote;

            if (request.Status == StockRequestStatusEnum.Approved)
            {
                stockRequest.ApprovedAt = DateTime.UtcNow;
            }

            foreach (var requestItem in request.Items)
            {
                var item = stockRequest.Items.FirstOrDefault(x => x.StockItemId == requestItem.StockItemId);
                if (item is null)
                {
                    continue;
                }

                item.ApprovedQuantity = requestItem.ApprovedQuantity ?? item.ApprovedQuantity;
                item.FulfilledQuantity = requestItem.FulfilledQuantity ?? item.FulfilledQuantity;
                item.UnitPrice = requestItem.UnitPrice ?? item.UnitPrice;
                item.Note = requestItem.Note ?? item.Note;
                await unitOfWork.GetWriteRepository<StockRequestItem>().UpdateAsync(item);
            }

            if (request.Status == StockRequestStatusEnum.Fulfilled)
            {
                stockRequest.FulfilledAt = DateTime.UtcNow;

                foreach (var item in stockRequest.Items)
                {
                    var stockItem = await unitOfWork.GetReadRepository<StockItem>().GetAsync(
                        x => x.Id == item.StockItemId && x.HotelId == stockRequest.HotelId && !x.IsDeleted);

                    var fulfilledQuantity = item.FulfilledQuantity ?? item.ApprovedQuantity ?? item.RequestedQuantity;
                    if (fulfilledQuantity <= 0)
                    {
                        continue;
                    }

                    if (stockItem.CurrentQuantity < fulfilledQuantity)
                    {
                        await unitOfWork.RollBackAsync(cancellationToken);
                        return new ResponseDto<UpdateStockRequestStatusCommandResponse>().Fail(
                            new List<string> { $"'{stockItem.Name}' stok kalemi icin yeterli miktar yok." }, 400);
                    }

                    stockItem.CurrentQuantity -= fulfilledQuantity;
                    await unitOfWork.GetWriteRepository<StockItem>().UpdateAsync(stockItem);

                    await unitOfWork.GetWriteRepository<StockMovement>().AddAsync(new StockMovement
                    {
                        HotelId = stockRequest.HotelId,
                        StockItemId = stockItem.Id,
                        DepartmentId = stockRequest.DepartmentId,
                        EmployeeId = stockRequest.RequestedByEmployeeId,
                        MovementType = StockMovementTypeEnum.UsageOut,
                        Quantity = fulfilledQuantity,
                        UnitPrice = item.UnitPrice ?? stockItem.AverageUnitCost,
                        TotalAmount = fulfilledQuantity * (item.UnitPrice ?? stockItem.AverageUnitCost),
                        Reason = stockRequest.Title,
                        ReferenceType = nameof(StockRequest),
                        ReferenceId = stockRequest.Id,
                        OccurredAt = DateTime.UtcNow
                    });
                }
            }

            await unitOfWork.GetWriteRepository<StockRequest>().UpdateAsync(stockRequest);
            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<UpdateStockRequestStatusCommandResponse>().Success(new UpdateStockRequestStatusCommandResponse
            {
                Id = stockRequest.Id,
                Status = stockRequest.Status,
                ApprovedAt = stockRequest.ApprovedAt,
                FulfilledAt = stockRequest.FulfilledAt
            });
        }
    }
}
