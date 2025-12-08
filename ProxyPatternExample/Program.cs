using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using ProxyPatternExample.Services.Abstract;
using ProxyPatternExample.Services.Concrete;

namespace ProxyPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddMemoryCache();

            services.AddScoped<ProductService>();

            services.AddScoped<IProductService>(sp =>
            {
                var inner = sp.GetRequiredService<ProductService>();
                var cache = sp.GetRequiredService<IMemoryCache>();
                return new CachedProductService(inner, cache);
            });

            var provider = services.BuildServiceProvider();

            var productService = provider.GetRequiredService<IProductService>();

            // İlk çağrı (gerçek kaynaktan okur)
            var p1 = productService.GetById(1);
            Console.WriteLine($"{p1.Name} - {p1.Price} TL");

            // İkinci çağrı (cache'den okur)
            var p2 = productService.GetById(1);
            Console.WriteLine($"{p2.Name} - {p2.Price} TL");

            Console.ReadLine();
        }
    }
}
