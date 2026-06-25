using System.Globalization;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorigoApp.Application.Bases;
using WorigoApp.Domain.Entites;
using WorigoApp.Persistence.Context;

namespace WorigoApp.Api.Controllers.Reception
{
    /// <summary>
    /// ReceptionCurrenciesController sınıfını temsil eder.
    /// </summary>
[ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/reception")]
    public class ReceptionCurrenciesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IHttpClientFactory _httpClientFactory;
/// <summary>
/// ReceptionCurrenciesController sınıfının yeni bir örneğini başlatır.
/// </summary>
public ReceptionCurrenciesController(AppDbContext dbContext, IHttpClientFactory httpClientFactory)
        {
            _dbContext = dbContext;
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// GetCurrencies işlemini gerçekleştirir.
        /// </summary>
[HttpGet("currencies")]
        public async Task<ResponseDto<IList<CurrencyResponse>>> GetCurrencies(CancellationToken cancellationToken)
        {
            var currencies = await _dbContext.Set<Currency>()
                .AsNoTracking()
                .Where(x => x.IsSupported && x.IsActive && !x.IsDeleted)
                .OrderBy(x => x.SortOrder)
                .ThenBy(x => x.Code)
                .Select(x => new CurrencyResponse
                {
                    Id = x.Id,
                    Code = x.Code,
                    Name = x.Name,
                    Symbol = x.Symbol,
                    Country = x.Country,
                    CultureCode = x.CultureCode,
                    DecimalDigits = x.DecimalDigits,
                    IsBaseCurrency = x.IsBaseCurrency
                })
                .ToListAsync(cancellationToken);

            return new ResponseDto<IList<CurrencyResponse>>().Success(currencies);
        }

        /// <summary>
        /// Convert işlemini gerçekleştirir.
        /// </summary>
        [HttpGet("currency/convert")]
        public async Task<ResponseDto<CurrencyConversionResponse>> Convert(
            [FromQuery] decimal amount,
            [FromQuery] string from = "TRY",
            [FromQuery] string to = "TRY",
            CancellationToken cancellationToken = default)
        {
            from = NormalizeCode(from);
            to = NormalizeCode(to);

            if (amount < 0)
            {
                return new ResponseDto<CurrencyConversionResponse>().Fail("Tutar negatif olamaz.", 400);
            }

            var supportedCodes = await _dbContext.Set<Currency>()
                .AsNoTracking()
                .Where(x => x.IsSupported && x.IsActive && !x.IsDeleted)
                .Select(x => x.Code)
                .ToListAsync(cancellationToken);

            if (!supportedCodes.Contains(from) || !supportedCodes.Contains(to))
            {
                return new ResponseDto<CurrencyConversionResponse>().Fail("Desteklenmeyen para birimi.", 400);
            }

            if (from == to)
            {
                return new ResponseDto<CurrencyConversionResponse>().Success(new CurrencyConversionResponse
                {
                    From = from,
                    To = to,
                    Amount = amount,
                    ConvertedAmount = amount,
                    Rate = 1,
                    RateDate = DateTime.UtcNow.Date,
                    Provider = "local"
                });
            }

            try
            {
                var url = $"https://open.er-api.com/v6/latest/{from}";
                using var client = _httpClientFactory.CreateClient();
                using var response = await client.GetAsync(url, cancellationToken);
                var content = await response.Content.ReadAsStringAsync(cancellationToken);

                if (!response.IsSuccessStatusCode)
                {
                    return new ResponseDto<CurrencyConversionResponse>().Fail("Kur servisine ulasilamadi.", (int)response.StatusCode);
                }

                using var document = JsonDocument.Parse(content);
                var root = document.RootElement;
                var result = root.TryGetProperty("result", out var resultElement) ? resultElement.GetString() : string.Empty;

                if (!string.Equals(result, "success", StringComparison.OrdinalIgnoreCase) ||
                    !root.TryGetProperty("rates", out var ratesElement) ||
                    !ratesElement.TryGetProperty(to, out var rateElement))
                {
                    return new ResponseDto<CurrencyConversionResponse>().Fail("Kur bilgisi bulunamadi.", 502);
                }

                var rate = rateElement.GetDecimal();
                var converted = decimal.Round(amount * rate, 2, MidpointRounding.AwayFromZero);
                var rateDate = root.TryGetProperty("time_last_update_utc", out var dateElement) &&
                               DateTime.TryParse(dateElement.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var parsedDate)
                    ? parsedDate.Date
                    : DateTime.UtcNow.Date;

                return new ResponseDto<CurrencyConversionResponse>().Success(new CurrencyConversionResponse
                {
                    From = from,
                    To = to,
                    Amount = amount,
                    ConvertedAmount = converted,
                    Rate = rate,
                    RateDate = rateDate,
                    Provider = "open.er-api.com"
                });
            }
            catch
            {
                return new ResponseDto<CurrencyConversionResponse>().Fail("Kur cevrimi tamamlanamadi.", 502);
            }
        }

        private static string NormalizeCode(string? code)
        {
            return string.IsNullOrWhiteSpace(code)
                ? "TRY"
                : code.Trim().ToUpperInvariant();
        }
    }

/// <summary>
/// CurrencyResponse sınıfını temsil eder.
/// </summary>
public class CurrencyResponse
    {
/// <summary>
/// Id değerini alır veya ayarlar.
/// </summary>
public int Id { get; set; }
/// <summary>
/// Code değerini alır veya ayarlar.
/// </summary>
public string Code { get; set; } = string.Empty;
/// <summary>
/// Name değerini alır veya ayarlar.
/// </summary>
public string Name { get; set; } = string.Empty;
/// <summary>
/// Symbol değerini alır veya ayarlar.
/// </summary>
public string Symbol { get; set; } = string.Empty;
/// <summary>
/// Country değerini alır veya ayarlar.
/// </summary>
public string Country { get; set; } = string.Empty;
/// <summary>
/// CultureCode değerini alır veya ayarlar.
/// </summary>
public string CultureCode { get; set; } = string.Empty;
/// <summary>
/// DecimalDigits değerini alır veya ayarlar.
/// </summary>
public int DecimalDigits { get; set; }
/// <summary>
/// IsBaseCurrency değerini alır veya ayarlar.
/// </summary>
public bool IsBaseCurrency { get; set; }
    }

/// <summary>
/// CurrencyConversionResponse sınıfını temsil eder.
/// </summary>
public class CurrencyConversionResponse
    {
/// <summary>
/// From değerini alır veya ayarlar.
/// </summary>
public string From { get; set; } = "TRY";
/// <summary>
/// To değerini alır veya ayarlar.
/// </summary>
public string To { get; set; } = "TRY";
/// <summary>
/// Amount değerini alır veya ayarlar.
/// </summary>
public decimal Amount { get; set; }
/// <summary>
/// ConvertedAmount değerini alır veya ayarlar.
/// </summary>
public decimal ConvertedAmount { get; set; }
/// <summary>
/// Rate değerini alır veya ayarlar.
/// </summary>
public decimal Rate { get; set; }
/// <summary>
/// RateDate değerini alır veya ayarlar.
/// </summary>
public DateTime RateDate { get; set; }
/// <summary>
/// Provider değerini alır veya ayarlar.
/// </summary>
public string Provider { get; set; } = string.Empty;
    }
}
