using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;

namespace WorigoApp.Application.Bases
{
    public class BaseHandler
    {
        public readonly IMapper mapper;
        public readonly IUnitOfWork unitOfWork;
        public BaseHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public int UserId
        {
            get
            {
                var httpContext = new HttpContextAccessor().HttpContext;
                if (httpContext == null) return 0;

                var idClaim = httpContext.User.FindFirst("Id")?.Value 
                              ?? httpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                return int.TryParse(idClaim, out var userId) ? userId : 0;
            }
        }
    }
}
