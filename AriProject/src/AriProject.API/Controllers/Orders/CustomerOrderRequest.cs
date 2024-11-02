using System.Collections.Generic;
using AriProject.Application.Orders;

namespace AriProject.API.Orders
{
    public class CustomerOrderRequest
    {
        public List<ProductDto> Products { get; set; }

        public string Currency { get; set; }
    }
}