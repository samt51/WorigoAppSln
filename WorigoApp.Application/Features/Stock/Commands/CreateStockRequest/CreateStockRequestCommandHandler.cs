using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Features.Stock.Commands.CreateStockRequest
{
    public class CreateStockRequestCommandHandler : BaseHandler, IRequestHandler<CreateStockRequestCommandRequest, ResponseDto<CreateStockRequestCommandResponse>>
    {
        public CreateStockRequestCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateStockRequestCommandResponse>> Handle(CreateStockRequestCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.Items.Count == 0)
            {
                return new ResponseDto<CreateStockRequestCommandResponse>().Fail(new List<string> { "En az bir stok kalemi girilmelidir." }, 400);
            }

            await unitOfWork.GetReadRepository<Hotel>().GetAsync(x => x.Id == request.HotelId && x.IsActive && !x.IsDeleted);
            await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == request.RequestedByEmployeeId && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);

            Department? department = null;
            if (request.DepartmentId.HasValue)
            {
                department = await unitOfWork.GetReadRepository<Department>().GetAsync(
                    x => x.Id == request.DepartmentId.Value && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);
            }

            if (request.RelatedServiceRequestId.HasValue)
            {
                await unitOfWork.GetReadRepository<ServiceRequest>().GetAsync(
                    x => x.Id == request.RelatedServiceRequestId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            var managerEmployeeId = request.AssignedManagerEmployeeId ?? department?.ManagerEmployeeId;
            if (managerEmployeeId.HasValue)
            {
                await unitOfWork.GetReadRepository<Employee>().GetAsync(x => x.Id == managerEmployeeId.Value && x.HotelId == request.HotelId && !x.IsDeleted);
            }

            foreach (var item in request.Items)
            {
                await unitOfWork.GetReadRepository<StockItem>().GetAsync(
                    x => x.Id == item.StockItemId && x.HotelId == request.HotelId && x.IsActive && !x.IsDeleted);
            }

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var stockRequest = await unitOfWork.GetWriteRepository<StockRequest>().AddAsync(new StockRequest
            {
                HotelId = request.HotelId,
                RequestedByEmployeeId = request.RequestedByEmployeeId,
                AssignedManagerEmployeeId = managerEmployeeId,
                DepartmentId = request.DepartmentId,
                RelatedServiceRequestId = request.RelatedServiceRequestId,
                Title = request.Title,
                Description = request.Description,
                Priority = request.Priority,
                RequestedAt = DateTime.UtcNow
            });

            await unitOfWork.SaveAsync(cancellationToken);

            foreach (var item in request.Items)
            {
                await unitOfWork.GetWriteRepository<StockRequestItem>().AddAsync(new StockRequestItem
                {
                    StockRequestId = stockRequest.Id,
                    StockItemId = item.StockItemId,
                    RequestedQuantity = item.RequestedQuantity,
                    ApprovedQuantity = item.ApprovedQuantity,
                    FulfilledQuantity = item.FulfilledQuantity,
                    UnitPrice = item.UnitPrice,
                    Note = item.Note
                });
            }

            await unitOfWork.SaveAsync(cancellationToken);
            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateStockRequestCommandResponse>().Success(new CreateStockRequestCommandResponse
            {
                Id = stockRequest.Id,
                Status = stockRequest.Status,
                RequestedAt = stockRequest.RequestedAt
            });
        }
    }
}
