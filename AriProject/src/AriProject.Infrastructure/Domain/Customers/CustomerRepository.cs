﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AriProject.Domain.Customers;
using AriProject.Domain.Customers.Orders;
using AriProject.Infrastructure.Database;
using AriProject.Infrastructure.SeedWork;

namespace AriProject.Infrastructure.Domain.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OrdersContext _context;

        public CustomerRepository(OrdersContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync(Customer customer)
        {
            await this._context.Customers.AddAsync(customer);
        }

        public async Task<Customer> GetByIdAsync(CustomerId id)
        {
            return await this._context.Customers
                .IncludePaths(
                    CustomerEntityTypeConfiguration.OrdersList, 
                    CustomerEntityTypeConfiguration.OrderProducts)
                .SingleAsync(x => x.Id == id);
        }
    }
}