using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    public class EmployeeDetailConfiguration : IEntityTypeConfiguration<EmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            var detail1 = new EmployeeDetail(1, 1, new DateTime(1995, 08, 18), null, "+905363988981", true, DateTime.Now, null, null, false);

            var detail2 = new EmployeeDetail(2, 2, new DateTime(1995, 08, 18), null, "+905363988982", true, DateTime.Now, null, null, false);

            var detail3 = new EmployeeDetail(3, 3, new DateTime(1995, 08, 18), null, "+905363988983", true, DateTime.Now, null, null, false);

            var detail4 = new EmployeeDetail(4, 4, new DateTime(1995, 08, 18), null, "+905363988984", true, DateTime.Now, null, null, false);

            var detail5 = new EmployeeDetail(5, 5, new DateTime(1995, 08, 18), null, "+905363988985", true, DateTime.Now, null, null, false);

            builder.HasData(detail1, detail2, detail3, detail4, detail5);
        }
    }
}
