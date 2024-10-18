using EcommerceBackend.Core.Models;

namespace EcommerceBackend.Core.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}