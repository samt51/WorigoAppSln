using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;
using WorigoApp.Domain.Enums;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Service
{
    [Authorize(Roles = "SystemAdmin,HotelAdmin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceRoleAssignmentsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public ServiceRoleAssignmentsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{hotelId}")]
        public async Task<ResponseDto<IList<ServiceRoleAssignmentDto>>> GetByHotel(int hotelId, [FromQuery] ServicesEnum? serviceType)
        {
            var query =
                from assignment in _dbContext.ServiceRoleAssignment.AsNoTracking()
                join employeeType in _dbContext.EmployeeType.AsNoTracking()
                    on assignment.EmployeeTypeRoleId equals employeeType.Id
                join department in _dbContext.Department.AsNoTracking()
                    on assignment.DepartmentId equals department.Id into departmentJoin
                from department in departmentJoin.DefaultIfEmpty()
                where assignment.HotelId == hotelId &&
                      !assignment.IsDeleted &&
                      (!serviceType.HasValue || assignment.ServicesEnumId == serviceType.Value)
                orderby assignment.ServicesEnumId, assignment.Priority
                select new ServiceRoleAssignmentDto
                {
                    Id = assignment.Id,
                    HotelId = assignment.HotelId,
                    DepartmentId = assignment.DepartmentId,
                    DepartmentName = department == null ? null : department.Name,
                    ServiceId = assignment.ServiceId,
                    ServicesEnumId = assignment.ServicesEnumId,
                    ServiceName = assignment.ServicesEnumId.ToString(),
                    EmployeeTypeRoleId = assignment.EmployeeTypeRoleId,
                    EmployeeTypeName = employeeType.Name,
                    IsPrimaryAssignment = assignment.IsPrimaryAssignment,
                    Priority = assignment.Priority,
                    SlaMinutes = assignment.SlaMinutes,
                    IsActive = assignment.IsActive
                };

            var assignments = await query.ToListAsync();
            return new ResponseDto<IList<ServiceRoleAssignmentDto>>().Success(assignments);
        }

        [HttpPost]
        public async Task<ResponseDto<ServiceRoleAssignmentDto>> Create(CreateServiceRoleAssignmentRequest request)
        {
            await ValidateReferencesAsync(request.HotelId, request.DepartmentId, request.EmployeeTypeRoleId);

            var exists = await _dbContext.ServiceRoleAssignment.AnyAsync(x =>
                x.HotelId == request.HotelId &&
                x.ServicesEnumId == request.ServicesEnumId &&
                x.EmployeeTypeRoleId == request.EmployeeTypeRoleId &&
                x.Priority == request.Priority &&
                !x.IsDeleted);

            if (exists)
            {
                return new ResponseDto<ServiceRoleAssignmentDto>().Fail("Bu servis tipi, personel tipi ve oncelik icin atama kurali zaten var.", 400);
            }

            var now = DateTime.UtcNow;
            var entity = new ServiceRoleAssignments
            {
                HotelId = request.HotelId,
                DepartmentId = request.DepartmentId,
                ServiceId = (int)request.ServicesEnumId,
                ServicesEnumId = request.ServicesEnumId,
                EmployeeTypeRoleId = request.EmployeeTypeRoleId,
                IsPrimaryAssignment = request.IsPrimaryAssignment,
                Priority = request.Priority,
                SlaMinutes = request.SlaMinutes,
                IsActive = request.IsActive,
                CreatedDate = now,
                ModifyDate = now
            };

            await _dbContext.ServiceRoleAssignment.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            var dto = await BuildDtoAsync(entity.Id);
            return new ResponseDto<ServiceRoleAssignmentDto>().Success(dto);
        }

        [HttpPut("{id}")]
        public async Task<ResponseDto<ServiceRoleAssignmentDto>> Update(int id, UpdateServiceRoleAssignmentRequest request)
        {
            var entity = await _dbContext.ServiceRoleAssignment.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            if (entity is null)
            {
                return new ResponseDto<ServiceRoleAssignmentDto>().Fail("Atama kurali bulunamadi.", 404);
            }

            await ValidateReferencesAsync(request.HotelId, request.DepartmentId, request.EmployeeTypeRoleId);

            entity.HotelId = request.HotelId;
            entity.DepartmentId = request.DepartmentId;
            entity.ServiceId = (int)request.ServicesEnumId;
            entity.ServicesEnumId = request.ServicesEnumId;
            entity.EmployeeTypeRoleId = request.EmployeeTypeRoleId;
            entity.IsPrimaryAssignment = request.IsPrimaryAssignment;
            entity.Priority = request.Priority;
            entity.SlaMinutes = request.SlaMinutes;
            entity.IsActive = request.IsActive;
            entity.ModifyDate = DateTime.UtcNow;

            await _dbContext.SaveChangesAsync();

            var dto = await BuildDtoAsync(entity.Id);
            return new ResponseDto<ServiceRoleAssignmentDto>().Success(dto);
        }

        [HttpDelete("{id}")]
        public async Task<ResponseDto<bool>> Delete(int id)
        {
            var entity = await _dbContext.ServiceRoleAssignment.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            if (entity is null)
            {
                return new ResponseDto<bool>().Fail(false, "Atama kurali bulunamadi.", 404);
            }

            entity.IsDeleted = true;
            entity.IsActive = false;
            entity.ModifyDate = DateTime.UtcNow;
            await _dbContext.SaveChangesAsync();

            return new ResponseDto<bool>().Success(true);
        }

        private async Task ValidateReferencesAsync(int hotelId, int? departmentId, int employeeTypeRoleId)
        {
            var hotelExists = await _dbContext.Hotel.AnyAsync(x => x.Id == hotelId && !x.IsDeleted);
            if (!hotelExists)
            {
                throw new Exception("Otel bulunamadi.");
            }

            if (departmentId.HasValue)
            {
                var departmentExists = await _dbContext.Department.AnyAsync(x =>
                    x.Id == departmentId.Value &&
                    x.HotelId == hotelId &&
                    !x.IsDeleted);

                if (!departmentExists)
                {
                    throw new Exception("Departman bulunamadi veya otele ait degil.");
                }
            }

            var employeeTypeExists = await _dbContext.EmployeeType.AnyAsync(x =>
                x.Id == employeeTypeRoleId &&
                !x.IsDeleted &&
                (!departmentId.HasValue || x.DepartmentId == departmentId.Value));

            if (!employeeTypeExists)
            {
                throw new Exception("Personel tipi bulunamadi veya secilen departmana ait degil.");
            }
        }

        private async Task<ServiceRoleAssignmentDto> BuildDtoAsync(int id)
        {
            return await (
                from assignment in _dbContext.ServiceRoleAssignment.AsNoTracking()
                join employeeType in _dbContext.EmployeeType.AsNoTracking()
                    on assignment.EmployeeTypeRoleId equals employeeType.Id
                join department in _dbContext.Department.AsNoTracking()
                    on assignment.DepartmentId equals department.Id into departmentJoin
                from department in departmentJoin.DefaultIfEmpty()
                where assignment.Id == id
                select new ServiceRoleAssignmentDto
                {
                    Id = assignment.Id,
                    HotelId = assignment.HotelId,
                    DepartmentId = assignment.DepartmentId,
                    DepartmentName = department == null ? null : department.Name,
                    ServiceId = assignment.ServiceId,
                    ServicesEnumId = assignment.ServicesEnumId,
                    ServiceName = assignment.ServicesEnumId.ToString(),
                    EmployeeTypeRoleId = assignment.EmployeeTypeRoleId,
                    EmployeeTypeName = employeeType.Name,
                    IsPrimaryAssignment = assignment.IsPrimaryAssignment,
                    Priority = assignment.Priority,
                    SlaMinutes = assignment.SlaMinutes,
                    IsActive = assignment.IsActive
                }).FirstAsync();
        }
    }

    public class CreateServiceRoleAssignmentRequest
    {
        public int HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public ServicesEnum ServicesEnumId { get; set; }
        public int EmployeeTypeRoleId { get; set; }
        public bool IsPrimaryAssignment { get; set; } = true;
        public int Priority { get; set; } = 1;
        public int? SlaMinutes { get; set; }
        public bool IsActive { get; set; } = true;
    }

    public class UpdateServiceRoleAssignmentRequest : CreateServiceRoleAssignmentRequest
    {
    }

    public class ServiceRoleAssignmentDto
    {
        public int Id { get; set; }
        public int? HotelId { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int ServiceId { get; set; }
        public ServicesEnum ServicesEnumId { get; set; }
        public string ServiceName { get; set; } = string.Empty;
        public int EmployeeTypeRoleId { get; set; }
        public string EmployeeTypeName { get; set; } = string.Empty;
        public bool IsPrimaryAssignment { get; set; }
        public int Priority { get; set; }
        public int? SlaMinutes { get; set; }
        public bool IsActive { get; set; }
    }
}
