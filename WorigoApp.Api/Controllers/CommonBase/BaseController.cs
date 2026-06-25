using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WorigoApp.Api.Controllers.CommonBase
{
    /// <summary>
    /// BaseController sınıfını temsil eder.
    /// </summary>
[Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IMediator mediator;
/// <summary>
/// BaseController sınıfının yeni bir örneğini başlatır.
/// </summary>
public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
         
    }
}
