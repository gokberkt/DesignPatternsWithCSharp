using ProxyPatternExample.Models;

namespace ProxyPatternExample.Services.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
    }
}
