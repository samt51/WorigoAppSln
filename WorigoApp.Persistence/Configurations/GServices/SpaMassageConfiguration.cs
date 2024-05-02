using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class SpaMassageConfiguration : IEntityTypeConfiguration<SpaMassage>
    {
        public void Configure(EntityTypeBuilder<SpaMassage> builder)
        {
            var spa1 = new SpaMassage(1, "Uzak Doğu", "Uzak Doğu Masajı");
            var spa2 = new SpaMassage(2, "Tailand Masajı", "Tailand Masajı");

            builder.HasData(spa1, spa2);
        }
    }
}
