using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Helpers;

namespace WorigoApp.Application.Filters
{
    /// <summary>
    /// ValidatorActionFilter sınıfını temsil eder.
    /// </summary>
    public class ValidatorActionFilter : IActionFilter
    {
        private readonly GetDataFromCache _getDataFromCache;
/// <summary>
/// ValidatorActionFilter sınıfının yeni bir örneğini başlatır.
/// </summary>
public ValidatorActionFilter(GetDataFromCache getDataFromCache)
        {
            _getDataFromCache = getDataFromCache;
        }
/// <summary>
/// OnActionExecuted işlemini gerçekleştirir.
/// </summary>
public void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                context.Result = new BadRequestObjectResult(new ResponseDto<NoContentResult>().Fail(errors, 200));
            }
        }
/// <summary>
/// OnActionExecuting işlemini gerçekleştirir.
/// </summary>
public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.ModelState.IsValid)
            {
         
                var errors = filterContext.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                filterContext.Result = new BadRequestObjectResult(new ResponseDto<NoContentResult>().Fail(errors, 200));
            }
        }
    }
}
