using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class SpaMassageValueConfiguration : IEntityTypeConfiguration<SpaMassageValue>
    {
        public void Configure(EntityTypeBuilder<SpaMassageValue> builder)
        {
         
        }
    }
}
