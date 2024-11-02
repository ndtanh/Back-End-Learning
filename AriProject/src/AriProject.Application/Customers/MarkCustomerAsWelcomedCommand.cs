using System;
using MediatR;
using Newtonsoft.Json;
using AriProject.Application.Configuration.Commands;
using AriProject.Domain.Customers;

namespace AriProject.Application.Customers
{
    public class MarkCustomerAsWelcomedCommand : InternalCommandBase<Unit>
    {
        [JsonConstructor]
        public MarkCustomerAsWelcomedCommand(Guid id, CustomerId customerId) : base(id)
        {
            CustomerId = customerId;
        }

        public CustomerId CustomerId { get; }
    }
}