﻿using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using AriProject.Domain.Customers.Orders;
using AriProject.Domain.SeedWork;

namespace AriProject.Domain.Customers.Rules
{
    public class OrderMustHaveAtLeastOneProductRule : IBusinessRule
    {
        private readonly List<OrderProductData> _orderProductData;

        public OrderMustHaveAtLeastOneProductRule(List<OrderProductData> orderProductData)
        {
            _orderProductData = orderProductData;
        }

        public bool IsBroken() => !_orderProductData.Any();

        public string Message => "Order must have at least one product";
    }
}