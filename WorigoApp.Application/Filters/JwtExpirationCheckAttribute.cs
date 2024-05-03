using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IdentityModel.Tokens.Jwt;

namespace WorigoApp.Application.Filters
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class JwtExpirationCheckAttribute : Attribute, IActionFilter
    {
        //Action Bazlı
        public void OnActionExecuted(ActionExecutedContext context)
        {
            return;
        }
        //Controller Bazlı
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var authorizationHeader = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();

            if (authorizationHeader == null || !authorizationHeader.StartsWith("Bearer "))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            var token = authorizationHeader.Substring("Bearer ".Length).Trim();

            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                var expirationDate = jwtToken.ValidTo;

                // Tokenın son kullanma tarihi geçmiş mi kontrol et
                if (expirationDate < DateTime.UtcNow)
                {
                    // Tokenın son kullanma tarihi geçmişse hata dön
                    context.Result = new UnauthorizedObjectResult("Token expired");
                    return;
                }
            }
            catch (Exception)
            {
                // Tokenın parse edilmesinde bir hata olursa
                context.Result = new UnauthorizedObjectResult("Invalid token");
                return;
            }
        }
    }
}
