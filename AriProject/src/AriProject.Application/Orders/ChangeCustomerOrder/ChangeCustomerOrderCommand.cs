using System;
using System.Collections.Generic;
using MediatR;
using AriProject.Application.Configuration.Commands;
using AriProject.Domain.Products;

namespace AriProject.Application.Orders.ChangeCustomerOrder
{
    public class ChangeCustomerOrderCommand : CommandBase<Unit>
    {
        public Guid CustomerId { get; }

        public Guid OrderId { get; }

        public string Currency { get; }

        public List<ProductDto> Products { get; }

        public ChangeCustomerOrderCommand(
            Guid customerId, 
            Guid orderId,
            List<ProductDto> products, 
            string currency)
        {
            this.CustomerId = customerId;
            this.OrderId = orderId;
            this.Currency = currency;
            this.Products = products;
        }
    }
}
