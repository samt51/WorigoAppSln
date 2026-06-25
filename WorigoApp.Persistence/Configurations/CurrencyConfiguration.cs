using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Persistence.Configurations
{
    /// <summary>
    /// CurrencyConfiguration sınıfını temsil eder.
    /// </summary>
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
/// <summary>
/// Configure işlemini gerçekleştirir.
/// </summary>
public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.Property(x => x.Code).HasMaxLength(3).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Symbol).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Country).HasMaxLength(100).IsRequired();
            builder.Property(x => x.CultureCode).HasMaxLength(20).IsRequired();

            builder.HasIndex(x => x.Code).IsUnique();

            builder.HasData(
                new Currency { Id = 1, Code = "TRY", Name = "Turkish Lira", Symbol = "₺", Country = "Türkiye", CultureCode = "tr-TR", DecimalDigits = 2, IsBaseCurrency = true, IsSupported = true, SortOrder = 1 },
                new Currency { Id = 2, Code = "USD", Name = "US Dollar", Symbol = "$", Country = "United States", CultureCode = "en-US", DecimalDigits = 2, IsBaseCurrency = false, IsSupported = true, SortOrder = 2 },
                new Currency { Id = 3, Code = "EUR", Name = "Euro", Symbol = "€", Country = "European Union", CultureCode = "de-DE", DecimalDigits = 2, IsBaseCurrency = false, IsSupported = true, SortOrder = 3 },
                new Currency { Id = 4, Code = "GBP", Name = "Pound Sterling", Symbol = "£", Country = "United Kingdom", CultureCode = "en-GB", DecimalDigits = 2, IsBaseCurrency = false, IsSupported = true, SortOrder = 4 },
                new Currency { Id = 5, Code = "SAR", Name = "Saudi Riyal", Symbol = "﷼", Country = "Saudi Arabia", CultureCode = "ar-SA", DecimalDigits = 2, IsBaseCurrency = false, IsSupported = true, SortOrder = 5 }
            );
        }
    }
}
