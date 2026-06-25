using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WorigoApp.Api.Controllers
{
    /// <summary>
    /// LangController sınıfını temsil eder.
    /// </summary>
[Route("[controller]/[action]")]
    [ApiController]
    public class LangController : Controller
    {
        readonly RequestLocalizationOptions _localizationOptions;
/// <summary>
/// LangController sınıfının yeni bir örneğini başlatır.
/// </summary>
public LangController(IOptions<RequestLocalizationOptions> localizationOptions)
            => _localizationOptions = localizationOptions.Value;

        /// <summary>
        /// AllLanguages işlemini gerçekleştirir.
        /// </summary>
[HttpGet]
        public IActionResult AllLanguages()
        {
            IRequestCultureFeature requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            var allCultures = _localizationOptions.SupportedCultures
                    .Select(culture => new
                    {
                        Name = culture.Name,
                        Text = culture.EnglishName,
                    }).ToList();
            return Ok(allCultures);
        }
    }
}
