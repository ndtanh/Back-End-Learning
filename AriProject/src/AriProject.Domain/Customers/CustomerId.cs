using System;
using AriProject.Domain.SeedWork;

namespace AriProject.Domain.Customers
{
    public class CustomerId : TypedIdValueBase
    {
        public CustomerId(Guid value) : base(value)
        {
        }
    }
}