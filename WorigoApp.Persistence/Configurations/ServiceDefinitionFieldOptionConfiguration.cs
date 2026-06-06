using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class ServiceDefinitionFieldOptionConfiguration : IEntityTypeConfiguration<ServiceDefinitionFieldOption>
    {
        public void Configure(EntityTypeBuilder<ServiceDefinitionFieldOption> builder)
        {
            builder.HasData(
                Option(1, 62, "extra_pillow", "Ek yastik", 1),
                Option(2, 62, "baby_bed", "Bebek yatagi", 2),
                Option(3, 62, "blanket", "Battaniye", 3),
                Option(4, 62, "ironing_board", "Utu masasi", 4),
                Option(5, 62, "other", "Diger", 5),

                Option(6, 68, "health", "Saglik", 1),
                Option(7, 68, "security", "Guvenlik", 2),
                Option(8, 68, "first_aid", "Ilk yardim", 3),
                Option(9, 68, "other", "Diger", 4)
            );
        }

        private static ServiceDefinitionFieldOption Option(int id, int fieldId, string value, string label, int displayOrder)
        {
            return new ServiceDefinitionFieldOption
            {
                Id = id,
                ServiceDefinitionFieldId = fieldId,
                Value = value,
                Label = label,
                DisplayOrder = displayOrder
            };
        }
    }
}
