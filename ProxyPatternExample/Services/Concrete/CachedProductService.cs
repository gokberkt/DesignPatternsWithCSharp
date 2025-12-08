using Microsoft.Extensions.Caching.Memory;
using ProxyPatternExample.Models;
using ProxyPatternExample.Services.Abstract;

namespace ProxyPatternExample.Services.Concrete
{
    public class CachedProductService : IProductService
    {
        private readonly IProductService _inner;
        private readonly IMemoryCache _cache;

        public CachedProductService(IProductService inner, IMemoryCache cache)
        {
            _inner = inner;
            _cache = cache;
        }

        public Product GetById(int id)
        {
            var cacheKey = $"product:{id}";

            if (_cache.TryGetValue(cacheKey, out Product? cached))
            {
                Console.WriteLine("Cache'den ürün okundu.");
                return cached!;
            }

            var product = _inner.GetById(id);

            _cache.Set(cacheKey, product, TimeSpan.FromMinutes(5));

            return product;
        }
    }
}
