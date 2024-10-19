using EcommerceBackend.Core.Models;
using System.Collections.Generic;

namespace EcommerceBackend.Core.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }
}