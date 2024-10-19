using EcommerceBackend.Core.Interfaces;
using EcommerceBackend.Core.Models;
using EcommerceBackend.Data;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceBackend.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList(); // List<Product> can be returned as IEnumerable<Product>
        }
    }
}