using System.Collections.Generic;
using AriProject.Domain.ForeignExchange;

namespace AriProject.Infrastructure.Domain.ForeignExchanges
{
    public class ConversionRatesCache
    {
        public List<ConversionRate> Rates { get; }

        public ConversionRatesCache(List<ConversionRate> rates)
        {
            this.Rates = rates;
        }
    }
}