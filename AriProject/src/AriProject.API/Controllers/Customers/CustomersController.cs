﻿using System.Net;
using System.Threading.Tasks;
using AriProject.Application.Customers;
using AriProject.Application.Customers.RegisterCustomer;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AriProject.API.Controllers.Customers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        /// <summary>
        /// Register customer.
        /// </summary>
        [Route("")]
        [HttpPost]
        [ProducesResponseType(typeof(CustomerDto), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> RegisterCustomer([FromBody]RegisterCustomerRequest request)
        {
           var customer = await _mediator.Send(new RegisterCustomerCommand(request.Email, request.Name));

           return Created(string.Empty, customer);
        }
    }
}