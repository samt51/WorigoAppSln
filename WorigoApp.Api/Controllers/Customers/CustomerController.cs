using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WorigoApp.Api.Controllers.CommonBase;
using WorigoApp.Application.Bases;
using WorigoApp.Application.Features.Customers.Commands.CreateCustomerByRoomBasedTransactionId;
using WorigoApp.Application.Features.RoomBasedTransactions.Commands.CreateCustomer;
using WorigoApp.Application.Features.RoomBasedTransactions.Commands.UpdatedCustomer;

namespace WorigoApp.Api.Controllers.Customers
{
    [Authorize(Roles = "SystemAdmin,Resepsiyonist")]
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
        [HttpPost]
        public async Task<Response<UpdatedCustomerCommandResponse>> UpdateGuest(UpdatedCustomerCommandRequest request)
        {
            return await this._mediator.Send(request);
        }
        [HttpPost]
        public async Task<Response<CreateCustomerByRoomBasedTransactionIdResponse>> NewCustomerByRoomBasedTransactionId(CreateCustomerByRoomBasedTransactionIdRequest request)
        {
            return await _mediator.Send(request);
        }
    }
}
