using System.Reflection;
using AriProject.Application.Orders.PlaceCustomerOrder;

namespace AriProject.Infrastructure.Processing
{
    internal static class Assemblies
    {
        public static readonly Assembly Application = typeof(PlaceCustomerOrderCommand).Assembly;
    }
}