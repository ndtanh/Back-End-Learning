﻿using AriProject.Domain.SeedWork;
using AriProject.Domain.SharedKernel;

namespace AriProject.Domain.Products
{
    public class ProductPriceData : ValueObject
    {
        public ProductPriceData(ProductId productId, MoneyValue price)
        {
            ProductId = productId;
            Price = price;
        }

        public ProductId ProductId { get; }

        public MoneyValue Price { get; }
    }
}