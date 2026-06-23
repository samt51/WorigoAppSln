using MediatR;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

using WorigoApp.Application.Interfaces.AutoMapper;

namespace WorigoApp.Application.Features.Transfers.Commands.AssignDriver
{
    public class AssignDriverCommandHandler : BaseHandler, IRequestHandler<AssignDriverCommandRequest, ResponseDto<AssignDriverResponse>>
    {
        public AssignDriverCommandHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<AssignDriverResponse>> Handle(AssignDriverCommandRequest request, CancellationToken cancellationToken)
        {
            var user = await unitOfWork.GetReadRepository<Users>().FindAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(x => x.Employee),
                enableTracking: false);

            if (user is null || user.Employee is null) return new ResponseDto<AssignDriverResponse>().Fail("Personel kaydı bulunamadı.", 401);

            var tracking = await unitOfWork.GetReadRepository<TransferTracking>().FindAsync(
                x => x.ServiceRequestId == request.ServiceRequestId && x.HotelId == user.Employee.HotelId && !x.IsDeleted,
                enableTracking: true);

            if (tracking is null)
            {
                var serviceRequest = await unitOfWork.GetReadRepository<ServiceRequest>().FindAsync(
                    x => x.Id == request.ServiceRequestId && x.HotelId == user.Employee.HotelId && !x.IsDeleted);

                if (serviceRequest is null) return new ResponseDto<AssignDriverResponse>().Fail("Servis talebi bulunamadı.", 404);

                tracking = new TransferTracking
                {
                    HotelId = user.Employee.HotelId ?? 0,
                    ServiceRequestId = request.ServiceRequestId,
                    GuestStayId = serviceRequest.GuestStayId,
                    CustomerId = serviceRequest.CustomerId ?? 0,
                    PickupLocation = "Hotel",
                    DropoffLocation = "Airport",
                    Status = "Assigned",
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };

                await unitOfWork.GetWriteRepository<TransferTracking>().AddAsync(tracking);
            }

            tracking.DriverName = request.DriverName;
            tracking.DriverPhone = request.DriverPhone;
            tracking.VehiclePlate = request.VehiclePlate;
            tracking.VehicleModel = request.VehicleModel;
            tracking.AssignedEmployeeId = user.Employee.Id;
            tracking.AssignedAt = DateTime.UtcNow;
            tracking.Status = "Assigned";
            tracking.ModifyDate = DateTime.Now;

            if (request.EstimatedArrivalTime.HasValue)
            {
                tracking.EstimatedArrivalTime = request.EstimatedArrivalTime.Value;
            }

            await unitOfWork.GetWriteRepository<TransferTracking>().UpdateAsync(tracking);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ResponseDto<AssignDriverResponse>().Success(new AssignDriverResponse
            {
                GuestStayId = tracking.GuestStayId,
                DriverName = tracking.DriverName,
                VehiclePlate = tracking.VehiclePlate,
                EstimatedArrivalTime = tracking.EstimatedArrivalTime
            });
        }
    }
}
