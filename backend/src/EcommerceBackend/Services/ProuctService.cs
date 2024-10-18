using EcommerceBackend.Core.Interfaces;
using EcommerceBackend.Core.Models;

namespace EcommerceBackend.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Product1", Price = 10.00m, Description = "Description for Product1" },
                new Product { Id = 2, Name = "Product2", Price = 20.00m, Description = "Description for Product2" },
                new Product { Id = 3, Name = "Product3", Price = 30.00m, Description = "Description for Product3" }
            };
        }
    }
}