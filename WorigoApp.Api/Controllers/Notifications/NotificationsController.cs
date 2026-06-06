using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Notifications
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public NotificationsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("employee/{employeeId}")]
        public async Task<ResponseDto<IList<UserNotificationDto>>> GetByEmployee(int employeeId, [FromQuery] bool unreadOnly = false, CancellationToken cancellationToken = default)
        {
            var query = _dbContext.UserNotifications
                .AsNoTracking()
                .Where(x => x.EmployeeId == employeeId && !x.IsDeleted);

            if (unreadOnly)
            {
                query = query.Where(x => !x.IsRead);
            }

            var data = await query
                .OrderBy(x => x.IsRead)
                .ThenByDescending(x => x.CreatedDate)
                .Take(100)
                .Select(x => new UserNotificationDto
                {
                    Id = x.Id,
                    HotelId = x.HotelId,
                    UserId = x.UserId,
                    EmployeeId = x.EmployeeId,
                    DepartmentId = x.DepartmentId,
                    ServiceRequestId = x.ServiceRequestId,
                    Title = x.Title,
                    Message = x.Message,
                    NotificationType = x.NotificationType,
                    IsRead = x.IsRead,
                    ReadAt = x.ReadAt,
                    CreatedDate = x.CreatedDate
                })
                .ToListAsync(cancellationToken);

            return new ResponseDto<IList<UserNotificationDto>>().Success(data);
        }

        [HttpGet("department/{departmentId}")]
        public async Task<ResponseDto<IList<UserNotificationDto>>> GetByDepartment(int departmentId, [FromQuery] bool unreadOnly = false, CancellationToken cancellationToken = default)
        {
            var query = _dbContext.UserNotifications
                .AsNoTracking()
                .Where(x => x.DepartmentId == departmentId && !x.IsDeleted);

            if (unreadOnly)
            {
                query = query.Where(x => !x.IsRead);
            }

            var data = await query
                .OrderBy(x => x.IsRead)
                .ThenByDescending(x => x.CreatedDate)
                .Take(100)
                .Select(x => new UserNotificationDto
                {
                    Id = x.Id,
                    HotelId = x.HotelId,
                    UserId = x.UserId,
                    EmployeeId = x.EmployeeId,
                    DepartmentId = x.DepartmentId,
                    ServiceRequestId = x.ServiceRequestId,
                    Title = x.Title,
                    Message = x.Message,
                    NotificationType = x.NotificationType,
                    IsRead = x.IsRead,
                    ReadAt = x.ReadAt,
                    CreatedDate = x.CreatedDate
                })
                .ToListAsync(cancellationToken);

            return new ResponseDto<IList<UserNotificationDto>>().Success(data);
        }

        [HttpPost("{notificationId}/read")]
        public async Task<ResponseDto<bool>> MarkAsRead(int notificationId, CancellationToken cancellationToken)
        {
            var notification = await _dbContext.UserNotifications
                .FirstOrDefaultAsync(x => x.Id == notificationId && !x.IsDeleted, cancellationToken);

            if (notification is null)
            {
                return new ResponseDto<bool>().Fail("Bildirim bulunamadi.", 404);
            }

            notification.IsRead = true;
            notification.ReadAt = DateTime.UtcNow;
            notification.ModifyDate = DateTime.UtcNow;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }

        [HttpPost("employee/{employeeId}/read-all")]
        public async Task<ResponseDto<bool>> MarkEmployeeNotificationsAsRead(int employeeId, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;
            var notifications = await _dbContext.UserNotifications
                .Where(x => x.EmployeeId == employeeId && !x.IsDeleted && !x.IsRead)
                .ToListAsync(cancellationToken);

            foreach (var notification in notifications)
            {
                notification.IsRead = true;
                notification.ReadAt = now;
                notification.ModifyDate = now;
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return new ResponseDto<bool>().Success(true);
        }
    }

    public class UserNotificationDto
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int? UserId { get; set; }
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ServiceRequestId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string NotificationType { get; set; } = string.Empty;
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
