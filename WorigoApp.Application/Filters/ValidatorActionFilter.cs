﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Application.Bases;

namespace WorigoApp.Application.Filters
{
    public class ValidatorActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                context.Result = new BadRequestObjectResult(new Response<NoContentResult>().Fail(errors, 200));
            }
        }
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.ModelState.IsValid)
            {
                var errors = filterContext.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                filterContext.Result = new BadRequestObjectResult(new Response<NoContentResult>().Fail(errors, 200));
            }
        }
    }
}
