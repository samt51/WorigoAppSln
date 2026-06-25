using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Application.Bases
{
    /// <summary>
    /// BaseHandler sınıfını temsil eder.
    /// </summary>
    public class BaseHandler
    {
        public readonly IMapper mapper;
        public readonly IUnitOfWork unitOfWork;
/// <summary>
/// BaseHandler sınıfının yeni bir örneğini başlatır.
/// </summary>
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
/// <summary>
/// CheckHotelAccessAsync işlemini gerçekleştirir.
/// </summary>
protected async Task<bool> CheckHotelAccessAsync(int requestedHotelId)
        {
            if (UserId == 0) return false;

            var user = await unitOfWork.GetReadRepository<Users>().GetAsync(
                x => x.Id == UserId && !x.IsDeleted,
                include: q => q.Include(u => u.Employee));

            if (user == null) return false;

            // SystemAdmin (Role 1) has access to all hotels
            if (user.RoleId == 1) return true;

            // Other users must belong to the requested hotel
            return user.Employee != null && user.Employee.HotelId == requestedHotelId;
        }
    }
}
