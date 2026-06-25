using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Application.Helpers;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// UserConfiguration sınıfını temsil eder.
    /// </summary>
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Users> builder)
        {
            var user = new Users(1, "samt51.m@icloud.com", PasswordHash.HashPassword("123456"), 1);

            #region Employee
            var user2 = new Users(2, "ahmet51@gmail.com", PasswordHash.HashPassword("123456"), 5);

            var user3 = new Users(3, "emre51@gmail.com", PasswordHash.HashPassword("123456"), 5);

            var user4 = new Users(4, "yunus51@gmail.com", PasswordHash.HashPassword("123456"), 5);

            var user5 = new Users(5, "fatih51@gmail.com", PasswordHash.HashPassword("123456"), 5);

            var user6 = new Users(6, "mehmet51@gmail.com", PasswordHash.HashPassword("123456"), 5);

            #endregion
            builder.HasData(user, user2, user3, user4, user5, user6);
        }
    }
}
