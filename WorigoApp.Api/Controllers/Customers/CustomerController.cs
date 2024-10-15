using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.RoomBasedTransactions.Commands.CreateCustomer;

namespace WorigoApp.Api.Controllers.Customers
{
    [Authorize(Roles = "SystemAdmin")]
    public class CustomerController : BaseController
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator) : base(mediator)
        {
            this._mediator = mediator;
        }
        [HttpPost]
        public async Task<Response<CreateCustomerCommandResponse>> CreateGuest(CreateCustomerCommandRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
