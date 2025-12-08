using ProxyPatternExample.Models;
using ProxyPatternExample.Services.Abstract;

namespace ProxyPatternExample.Services.Concrete
{
    public class ProductService : IProductService
    {
        // Gerçekte bu kısım DB olur, burada örnek olarak in-memory liste kullanıyoruz.
        private static readonly List<Product> _products =
        [
            new() { Id = 1, Name = "Kulaklık", Price = 500 },
            new() { Id = 2, Name = "Klavye",   Price = 750 },
            new() { Id = 3, Name = "Monitör",  Price = 3500 }
        ];

        public Product GetById(int id)
        {
            Console.WriteLine("Kaynak sistemden ürün okunuyor...");

            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product is null)
                throw new InvalidOperationException("Ürün bulunamadı.");

            return product;
        }
    }
}
