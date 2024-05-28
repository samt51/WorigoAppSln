using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace WorigoApp.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LangController : Controller
    {
        readonly RequestLocalizationOptions _localizationOptions;

        public LangController(IOptions<RequestLocalizationOptions> localizationOptions)
            => _localizationOptions = localizationOptions.Value;

        [HttpGet]
        public IActionResult AllLanguages()
        {
            IRequestCultureFeature requestCulture = HttpContext.Features.Get<IRequestCultureFeature>();
            var allCultures = _localizationOptions.SupportedCultures
                    .Select(culture => new
                    {
                        Name = culture.Name,
                        Text = culture.DisplayName
                    }).ToList();
            return Ok(allCultures);
        }
    }
}
