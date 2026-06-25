using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace WorigoApp.Application.Filters
{
    /// <summary>
    /// DescriptionOperationFilter sınıfını temsil eder.
    /// </summary>
    public class DescriptionOperationFilter : IOperationFilter
    {
/// <summary>
/// Apply işlemini gerçekleştirir.
/// </summary>
public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var methodInfo = context.MethodInfo;
            var descriptionAttribute = methodInfo.GetCustomAttribute<SwaggerDescriptionAttirbute>();

            if (descriptionAttribute != null)
            {
                operation.Summary = descriptionAttribute.Summary;
            }
        }
    }

}
