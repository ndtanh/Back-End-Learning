﻿using System.Threading;
using System.Threading.Tasks;
using Dapper;
using AriProject.Application.Configuration.Data;
using AriProject.Application.Configuration.Queries;

namespace AriProject.Application.Customers.GetCustomerDetails
{
    public class GetCustomerDetailsQueryHandler : IQueryHandler<GetCustomerDetailsQuery, CustomerDetailsDto>
    {
        private readonly ISqlConnectionFactory _sqlConnectionFactory;

        public GetCustomerDetailsQueryHandler(ISqlConnectionFactory sqlConnectionFactory)
        {
            _sqlConnectionFactory = sqlConnectionFactory;
        }

        public Task<CustomerDetailsDto> Handle(GetCustomerDetailsQuery request, CancellationToken cancellationToken)
        {
            const string sql = "SELECT " +
                               "[Customer].[Id], " +
                               "[Customer].[Name], " +
                               "[Customer].[Email], " +
                               "[Customer].[WelcomeEmailWasSent] " +
                               "FROM orders.v_Customers AS [Customer] " +
                               "WHERE [Customer].[Id] = @CustomerId ";

            var connection = _sqlConnectionFactory.GetOpenConnection();

            return connection.QuerySingleAsync<CustomerDetailsDto>(sql, new
            {
                request.CustomerId
            });
        }
    }
}