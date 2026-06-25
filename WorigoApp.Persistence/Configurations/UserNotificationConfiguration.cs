using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// UserNotificationConfiguration sınıfını temsil eder.
    /// </summary>
    public class UserNotificationConfiguration : IEntityTypeConfiguration<UserNotification>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<UserNotification> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Message).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.NotificationType).HasMaxLength(64).IsRequired();

            builder.HasIndex(x => new { x.HotelId, x.IsRead, x.CreatedDate });
            builder.HasIndex(x => new { x.EmployeeId, x.IsRead, x.CreatedDate });
            builder.HasIndex(x => new { x.DepartmentId, x.IsRead, x.CreatedDate });
            builder.HasIndex(x => x.ServiceRequestId);
        }
    }
}
