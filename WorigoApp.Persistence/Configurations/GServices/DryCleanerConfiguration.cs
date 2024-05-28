using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites.GServices;

namespace WorigoApp.Persistence.Configurations.GServices
{
    public class DryCleanerConfiguration : IEntityTypeConfiguration<DryCleaner>
    {
        public void Configure(EntityTypeBuilder<DryCleaner> builder)
        {
         
        }
    }
}
