using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Notifications
{
    /// <summary>
    /// NotificationsController sınıfını temsil eder.
    /// </summary>
[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
/// <summary>
/// NotificationsController sınıfının yeni bir örneğini başlatır.
/// </summary>
public NotificationsController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// GetByEmployee işlemini gerçekleştirir.
        /// </summary>
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

        /// <summary>
        /// GetByDepartment işlemini gerçekleştirir.
        /// </summary>
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

        /// <summary>
        /// MarkAsRead işlemini gerçekleştirir.
        /// </summary>
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

        /// <summary>
        /// MarkEmployeeNotificationsAsRead işlemini gerçekleştirir.
        /// </summary>
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

/// <summary>
/// UserNotificationDto sınıfını temsil eder.
/// </summary>
public class UserNotificationDto
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// HotelId değerini alır veya ayarlar.
/// </summary>
public int HotelId { get; set; }
/// <summary>
/// UserId değerini alır veya ayarlar.
/// </summary>
public int? UserId { get; set; }
/// <summary>
/// EmployeeId değerini alır veya ayarlar.
/// </summary>
public int? EmployeeId { get; set; }
/// <summary>
/// DepartmentId değerini alır veya ayarlar.
/// </summary>
public int? DepartmentId { get; set; }
/// <summary>
/// ServiceRequestId değerini alır veya ayarlar.
/// </summary>
public int? ServiceRequestId { get; set; }
/// <summary>
/// Title değerini alır veya ayarlar.
/// </summary>
public string Title { get; set; } = string.Empty;
/// <summary>
/// Message değerini alır veya ayarlar.
/// </summary>
public string Message { get; set; } = string.Empty;
/// <summary>
/// NotificationType değerini alır veya ayarlar.
/// </summary>
public string NotificationType { get; set; } = string.Empty;
/// <summary>
/// IsRead değerini alır veya ayarlar.
/// </summary>
public bool IsRead { get; set; }
/// <summary>
/// ReadAt değerini alır veya ayarlar.
/// </summary>
public DateTime? ReadAt { get; set; }
/// <summary>
/// CreatedDate değerini alır veya ayarlar.
/// </summary>
public DateTime CreatedDate { get; set; }
    }
}
