using Autofac;
using AriProject.Application.Customers.DomainServices;
using AriProject.Domain.Customers;
using AriProject.Domain.ForeignExchange;
using AriProject.Infrastructure.Domain.ForeignExchanges;

namespace AriProject.Infrastructure.Domain
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerUniquenessChecker>()
                .As<ICustomerUniquenessChecker>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ForeignExchange>()
                .As<IForeignExchange>()
                .InstancePerLifetimeScope();
        }
    }
}