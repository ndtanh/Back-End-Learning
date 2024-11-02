using System;
using System.Collections.Generic;
using System.Linq;
using AriProject.Domain.SeedWork;
using AriProject.Domain.SharedKernel;

namespace AriProject.Domain.Products
{
    public class Product : Entity, IAggregateRoot
    {
        public ProductId Id { get; private set; }

        public string Name { get; private set; }

        private List<ProductPrice> _prices;

        private Product(List<ProductPrice> prices)
        {
            _prices = prices;
        }
    }
}