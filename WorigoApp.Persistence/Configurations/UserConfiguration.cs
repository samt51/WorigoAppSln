using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Application.Helpers;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            var user = new Users(1,"samt51.m@icloud.com", PasswordHash.HashPassword("123456"), 1);

            builder.HasData(user);
        }
    }
}
