using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// CompanyConfiguration sınıfını temsil eder.
    /// </summary>
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Company> builder)
        {
            Company company = new Company(1, "Worigo");
            Company company2 = new Company(2, "Ramada");

            builder.HasData(company, company2);
        }
    }
}
