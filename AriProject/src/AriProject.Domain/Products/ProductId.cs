using System;
using AriProject.Domain.SeedWork;

namespace AriProject.Domain.Products
{
    public class ProductId : TypedIdValueBase
    {
        public ProductId(Guid value) : base(value)
        {
        }
    }
}