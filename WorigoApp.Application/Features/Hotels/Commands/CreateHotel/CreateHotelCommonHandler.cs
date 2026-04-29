using MediatR;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Application.Features.Hotels.Commands.CreateHotel
{
    public class CreateHotelCommonHandler : BaseHandler, IRequestHandler<CreateHotelCommonRequest, ResponseDto<CreateHotelCommonResponse>>
    {
        private const int TemplateHotelId = 1;

        public CreateHotelCommonHandler(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateHotelCommonResponse>> Handle(CreateHotelCommonRequest request, CancellationToken cancellationToken)
        {
            await unitOfWork.GetReadRepository<Company>().GetAsync(x => x.Id == request.Companyid && !x.IsDeleted);

            var mapEntity = mapper.Map<Hotel, CreateHotelCommonRequest>(request);

            await unitOfWork.OpenTransactionAsync(cancellationToken);

            var createdHotel = await unitOfWork.GetWriteRepository<Hotel>().AddAsync(mapEntity);
            await unitOfWork.SaveAsync(cancellationToken);

            await CloneTemplateDataAsync(createdHotel.Id, cancellationToken);

            await unitOfWork.CommitAsync(cancellationToken);

            return new ResponseDto<CreateHotelCommonResponse>().Success();
        }

        private async Task CloneTemplateDataAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateShifts = await unitOfWork.GetReadRepository<Shift>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedShifts = templateShifts.Select(x => new Shift
            {
                Name = x.Name,
                StartTime = x.StartTime,
                EndTime = x.EndTime,
                HotelId = hotelId,
                Description = x.Description,
                IsNightShift = x.IsNightShift,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<Shift>().AddRangeAsync(clonedShifts);
            await unitOfWork.SaveAsync(cancellationToken);

            var templateDepartments = await unitOfWork.GetReadRepository<Department>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedDepartments = templateDepartments.Select(x => new Department
            {
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                DisplayOrder = x.DisplayOrder,
                IsGuestFacing = x.IsGuestFacing,
                HotelId = hotelId,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<Department>().AddRangeAsync(clonedDepartments);
            await unitOfWork.SaveAsync(cancellationToken);

            var departmentMap = templateDepartments.Zip(clonedDepartments, (oldDep, newDep) => new { oldDep.Id, NewId = newDep.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateEmployeeTypes = await unitOfWork.GetReadRepository<EmployeeType>()
                .GetAllAsync(x => templateDepartments.Select(y => y.Id).Contains(x.DepartmentId) && !x.IsDeleted);

            var clonedEmployeeTypes = templateEmployeeTypes.Select(x => new EmployeeType
            {
                Name = x.Name,
                DepartmentId = departmentMap[x.DepartmentId],
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<EmployeeType>().AddRangeAsync(clonedEmployeeTypes);
            await unitOfWork.SaveAsync(cancellationToken);

            var employeeTypeMap = templateEmployeeTypes.Zip(clonedEmployeeTypes, (oldType, newType) => new { oldType.Id, NewId = newType.Id })
                .ToDictionary(x => x.Id, x => x.NewId);

            var templateAssignments = await unitOfWork.GetReadRepository<ServiceRoleAssignments>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedAssignments = templateAssignments.Select(x => new ServiceRoleAssignments
            {
                HotelId = hotelId,
                DepartmentId = x.DepartmentId.HasValue && departmentMap.ContainsKey(x.DepartmentId.Value) ? departmentMap[x.DepartmentId.Value] : null,
                EmployeeTypeRoleId = employeeTypeMap.ContainsKey(x.EmployeeTypeRoleId) ? employeeTypeMap[x.EmployeeTypeRoleId] : x.EmployeeTypeRoleId,
                ServiceId = x.ServiceId,
                ServicesEnumId = x.ServicesEnumId,
                IsPrimaryAssignment = x.IsPrimaryAssignment,
                Priority = x.Priority,
                SlaMinutes = x.SlaMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<ServiceRoleAssignments>().AddRangeAsync(clonedAssignments);
            await unitOfWork.SaveAsync(cancellationToken);

            await CloneTechnicalNeedsAsync(hotelId, cancellationToken);
            await CloneHouseKeepingAsync(hotelId, cancellationToken);
            await CloneBellBoyAsync(hotelId, cancellationToken);
            await CloneDryCleanerAsync(hotelId, cancellationToken);
            await CloneSpaAsync(hotelId, cancellationToken);
            await CloneMinibarAsync(hotelId, cancellationToken);
            await CloneWakeUpCallAsync(hotelId, cancellationToken);
            await CloneValetParkingAsync(hotelId, cancellationToken);
            await CloneStayExtensionAsync(hotelId, cancellationToken);
            await CloneAmenityRequestAsync(hotelId, cancellationToken);
            await CloneMedicalAssistanceAsync(hotelId, cancellationToken);
            await CloneTravelOrTransportationAsync(hotelId, cancellationToken);
            await CloneAnnouncementTemplatesAsync(hotelId, cancellationToken);
        }

        private async Task CloneTechnicalNeedsAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<TechnicalNeed>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new TechnicalNeed
            {
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                ParentId = x.ParentId,
                DisplayOrder = x.DisplayOrder,
                IsVisibleToGuest = x.IsVisibleToGuest,
                SupportsFreeText = x.SupportsFreeText,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                SlaMinutes = x.SlaMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<TechnicalNeed>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneHouseKeepingAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<HouseKeeping>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new HouseKeeping
            {
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                ParentId = x.ParentId,
                DisplayOrder = x.DisplayOrder,
                IsVisibleToGuest = x.IsVisibleToGuest,
                SupportsFreeText = x.SupportsFreeText,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<HouseKeeping>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneBellBoyAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<BellBoy>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new BellBoy
            {
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<BellBoy>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneDryCleanerAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<DryCleaner>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new DryCleaner
            {
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                ParentId = x.ParentId,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                DisplayOrder = x.DisplayOrder,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                CurrencyCode = x.CurrencyCode,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<DryCleaner>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneSpaAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<SpaMassage>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new SpaMassage
            {
                Name = x.Name,
                Description = x.Description,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                ParentId = x.ParentId,
                TypesOfHealthAndSports = x.TypesOfHealthAndSports,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                RequiresAppointment = x.RequiresAppointment,
                CurrencyCode = x.CurrencyCode,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<SpaMassage>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneMinibarAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<MinibarService>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new MinibarService
            {
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                DisplayOrder = x.DisplayOrder,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                CurrencyCode = x.CurrencyCode,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<MinibarService>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneWakeUpCallAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<WakeUpCallService>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new WakeUpCallService
            {
                Name = x.Name,
                Description = x.Description,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                CurrencyCode = x.CurrencyCode,
                RequiresAppointment = x.RequiresAppointment,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<WakeUpCallService>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneValetParkingAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<ValetParkingService>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new ValetParkingService
            {
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                CurrencyCode = x.CurrencyCode,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<ValetParkingService>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneStayExtensionAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<StayExtensionService>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new StayExtensionService
            {
                Name = x.Name,
                Description = x.Description,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsChargeable = x.IsChargeable,
                CurrencyCode = x.CurrencyCode,
                RequiresAppointment = x.RequiresAppointment,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<StayExtensionService>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneAmenityRequestAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<AmenityRequestService>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new AmenityRequestService
            {
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                DisplayOrder = x.DisplayOrder,
                IsVisibleToGuest = x.IsVisibleToGuest,
                SupportsFreeText = x.SupportsFreeText,
                IsChargeable = x.IsChargeable,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                CurrencyCode = x.CurrencyCode,
                EstimatedDurationMinutes = x.EstimatedDurationMinutes,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<AmenityRequestService>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneMedicalAssistanceAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<MedicalAssistanceService>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new MedicalAssistanceService
            {
                Name = x.Name,
                Description = x.Description,
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                IsVisibleToGuest = x.IsVisibleToGuest,
                SupportsFreeText = x.SupportsFreeText,
                IsChargeable = x.IsChargeable,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                CurrencyCode = x.CurrencyCode,
                RequiresAppointment = x.RequiresAppointment,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<MedicalAssistanceService>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneTravelOrTransportationAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<TravelOrTransportation>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new TravelOrTransportation
            {
                HotelId = hotelId,
                DepartmentId = x.DepartmentId,
                TransportationType = x.TransportationType,
                TransportationAddress = x.TransportationAddress,
                TransportationVehicle = x.TransportationVehicle,
                RequestDate = x.RequestDate,
                Price = x.Price,
                PriceStatusId = x.PriceStatusId,
                IsChargeable = x.IsChargeable,
                IsVisibleToGuest = x.IsVisibleToGuest,
                CurrencyCode = x.CurrencyCode,
                Description = x.Description,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<TravelOrTransportation>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }

        private async Task CloneAnnouncementTemplatesAsync(int hotelId, CancellationToken cancellationToken)
        {
            var templateData = await unitOfWork.GetReadRepository<HotelInformationAndAnnouncements>()
                .GetAllAsync(x => x.HotelId == TemplateHotelId && !x.IsDeleted);

            var clonedData = templateData.Select(x => new HotelInformationAndAnnouncements
            {
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                Date = x.Date,
                HotelId = hotelId,
                AnnouncementType = x.AnnouncementType,
                EndDate = x.EndDate,
                Location = x.Location,
                IsPinned = x.IsPinned,
                IsVisibleToGuest = x.IsVisibleToGuest,
                IsActive = x.IsActive
            }).ToList();

            await unitOfWork.GetWriteRepository<HotelInformationAndAnnouncements>().AddRangeAsync(clonedData);
            await unitOfWork.SaveAsync(cancellationToken);
        }
    }
}
