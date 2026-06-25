using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Hotels.Commands.CreateHotel;
using WorigoApp.Application.Features.Hotels.Commands.DeleteHotel;
using WorigoApp.Application.Features.Hotels.Commands.UpdateHotel;
using WorigoApp.Application.Features.Hotels.Queries.GetAllHotels;
using WorigoApp.Application.Features.Hotels.Queries.GetByIdHotel;
using WorigoApp.Application.Filters;
using WorigoApp.Application.Interfaces.AutoMapper;
using WorigoApp.Application.Interfaces.UnitOfWorks;
using WorigoApp.Domain.Entites;

namespace WorigoApp.Api.Controllers.Hotels
{
    /// <summary>
    /// HotelController sınıfını temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin,HotelAdmin")]
    public class HotelController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
/// <summary>
/// HotelController sınıfının yeni bir örneğini başlatır.
/// </summary>
public HotelController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper) : base(mediator)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        /// <summary>
        /// GetAllAsync işlemini gerçekleştirir.
        /// </summary>
[HttpGet]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<IList<GetAllHotelsQueryResponse>>> GetAllAsync([FromQuery] int companyId)
        {
            var result = await this._mediator.Send(new GetAllHotelsQueryRequest(companyId));
            return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Success(result);
        }

        /// <summary>
        /// GetMyHotelsAsync işlemini gerçekleştirir.
        /// </summary>
[HttpGet("my-hotels")]
        public async Task<ResponseDto<IList<GetAllHotelsQueryResponse>>> GetMyHotelsAsync()
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
            {
                return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Fail(new List<string> { "Kullanıcı bilgisi alınamadı." }, 401);
            }

            var userRole = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Role || x.Type == "role")?.Value;
            if (userRole == "SystemAdmin" || User.IsInRole("SystemAdmin"))
            {
                var allHotels = await _unitOfWork.GetReadRepository<Hotel>().GetAllAsync(x => !x.IsDeleted);
                var mappedAll = _mapper.Map<GetAllHotelsQueryResponse, Hotel>(allHotels);
                return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Success(mappedAll);
            }

            var employee = await _unitOfWork.GetReadRepository<Employee>()
                .GetAsync(x => x.UserId == userId && !x.IsDeleted);

            if (employee == null || !employee.HotelId.HasValue)
            {
                return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Fail(new List<string> { "Çalışan veya otel ilişkisi bulunamadı." }, 404);
            }

            var hotel = await _unitOfWork.GetReadRepository<Hotel>()
                .GetAsync(x => x.Id == employee.HotelId.Value && !x.IsDeleted);

            if (hotel == null)
            {
                return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Fail(new List<string> { "Otel bulunamadı." }, 404);
            }

            var hotels = await _unitOfWork.GetReadRepository<Hotel>()
                .GetAllAsync(x => x.Companyid == hotel.Companyid && !x.IsDeleted);

            var mapped = _mapper.Map<GetAllHotelsQueryResponse, Hotel>(hotels);

            return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Success(mapped);
        }

        /// <summary>
        /// AddAsync işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<CreateHotelCommonResponse>> AddAsync(CreateHotelCommonRequest request)
        {
            return await this._mediator.Send(request);
        }

        /// <summary>
        /// UpdateAsync işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<UpdateHotelCommonResponse>> UpdateAsync(UpdateHotelCommonRequest request)
        {
            return await this._mediator.Send(request);
        }

        /// <summary>
        /// DeleteAsync işlemini gerçekleştirir.
        /// </summary>
[HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<DeleteHotelCommandResponse>> DeleteAsync(DeleteHotelCommandRequest request)
        {
            return await this._mediator.Send(request);
        }

        /// <summary>
        /// GetByIdAsync işlemini gerçekleştirir.
        /// </summary>
[HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdHotelQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdHotelQueryRequest(id));
        }
    }
}
