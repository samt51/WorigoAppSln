using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class RoomBasedTransactionConfiguration : IEntityTypeConfiguration<RoomBasedTransaction>
    {
        public void Configure(EntityTypeBuilder<RoomBasedTransaction> builder)
        {
            var data = new RoomBasedTransaction(1, 1, 1, DateTime.Now, DateTime.Now.AddDays(2), Guid.NewGuid().ToString());

            builder.HasData(data);
        }
    }
}
