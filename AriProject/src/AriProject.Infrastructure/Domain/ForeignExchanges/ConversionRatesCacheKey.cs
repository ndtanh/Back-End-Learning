using AriProject.Infrastructure.Caching;

namespace AriProject.Infrastructure.Domain.ForeignExchanges
{
    public class ConversionRatesCacheKey : ICacheKey<ConversionRatesCache>
    {
        public string CacheKey => "ConversionRatesCache";
    }
}