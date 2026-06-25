using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Customers.Commands.CreateCustomerByGuestStayId;
using WorigoApp.Application.Features.GuestStays.Commands.CreateCustomer;
using WorigoApp.Application.Features.GuestStays.Commands.UpdatedCustomer;
using WorigoApp.Application.Filters;

namespace WorigoApp.Api.Controllers.Customers
{
    /// <summary>
    /// CustomerController sýnýfýný temsil eder.
    /// </summary>
[Authorize(Roles = "SystemAdmin,Employee")]
    public class CustomerController : BaseController
    {
        private readonly IMediator _mediator;
/// <summary>
/// CustomerController sýnýfýnýn yeni bir örneðini baþlatýr.
/// </summary>
public CustomerController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        /// <summary>
        /// Yeni Misafir giriþi yapar.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Yeni Misafir giriþi yapar.")]
        public async Task<ResponseDto<CreateCustomerCommandResponse>> CreateGuest(CreateCustomerCommandRequest request)
        {
            return await _mediator.Send(request);
        }
        /// <summary>
        /// Misafir ile ilgili iþleri ve süreyi uzatma gibi güncelleme yapar.
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Misafir ile ilgili iþleri ve süreyi uzatma gibi güncelleme yapar.")]
        public async Task<ResponseDto<UpdatedCustomerCommandResponse>> UpdateGuest(UpdatedCustomerCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        /// <summary>
        /// Ýlgili odaya kullanýcý tanýmlar
        /// </summary>
[HttpPost]
        [SwaggerDescriptionAttirbute("Ýlgili odaya kullanýcý tanýmlar")]
        public async Task<ResponseDto<CreateCustomerByGuestStayIdResponse>> NewCustomerByGuestStayId(CreateCustomerByGuestStayIdRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
