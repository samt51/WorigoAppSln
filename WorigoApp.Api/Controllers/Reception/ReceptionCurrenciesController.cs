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
    [ApiController]
    [Authorize(Roles = "SystemAdmin,HotelAdmin,Management,DepartmentManager,Employee")]
    [Route("api/reception")]
    public class ReceptionCurrenciesController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly IHttpClientFactory _httpClientFactory;

        public ReceptionCurrenciesController(AppDbContext dbContext, IHttpClientFactory httpClientFactory)
        {
            _dbContext = dbContext;
            _httpClientFactory = httpClientFactory;
        }

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

    public class CurrencyResponse
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Symbol { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string CultureCode { get; set; } = string.Empty;
        public int DecimalDigits { get; set; }
        public bool IsBaseCurrency { get; set; }
    }

    public class CurrencyConversionResponse
    {
        public string From { get; set; } = "TRY";
        public string To { get; set; } = "TRY";
        public decimal Amount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public decimal Rate { get; set; }
        public DateTime RateDate { get; set; }
        public string Provider { get; set; } = string.Empty;
    }
}
