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
    [Authorize(Roles = "SystemAdmin,HotelAdmin")]
    public class HotelController : BaseController
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HotelController(IMediator mediator, IUnitOfWork unitOfWork, IMapper mapper) : base(mediator)
        {
            this._mediator = mediator;
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpGet]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<IList<GetAllHotelsQueryResponse>>> GetAllAsync([FromQuery] int companyId)
        {
            var result = await this._mediator.Send(new GetAllHotelsQueryRequest(companyId));
            return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Success(result);
        }

        [HttpGet("my-hotels")]
        public async Task<ResponseDto<IList<GetAllHotelsQueryResponse>>> GetMyHotelsAsync()
        {
            var userIdClaim = User.Claims.FirstOrDefault(x => x.Type == "Id")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
            {
                return new ResponseDto<IList<GetAllHotelsQueryResponse>>().Fail(new List<string> { "Kullanıcı bilgisi alınamadı." }, 401);
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

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<CreateHotelCommonResponse>> AddAsync(CreateHotelCommonRequest request)
        {
            return await this._mediator.Send(request);
        }

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<UpdateHotelCommonResponse>> UpdateAsync(UpdateHotelCommonRequest request)
        {
            return await this._mediator.Send(request);
        }

        [HttpPost]
        [Authorize(Roles = "SystemAdmin")]
        public async Task<ResponseDto<DeleteHotelCommandResponse>> DeleteAsync(DeleteHotelCommandRequest request)
        {
            return await this._mediator.Send(request);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdHotelQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdHotelQueryRequest(id));
        }
    }
}
