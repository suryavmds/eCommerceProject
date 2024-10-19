using EcommerceBackend.Core.Interfaces;
using EcommerceBackend.Core.Models;
using EcommerceBackend.Services;
using EcommerceBackend.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;
using System.Collections.Generic;
using System.Linq;

public class ProductServiceTests
{
    private readonly IProductService _productService;
    private readonly ApplicationDbContext _context;

    public ProductServiceTests()
    {
        // Set up InMemoryDatabase for testing
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                      .UseInMemoryDatabase(databaseName: "TestDatabase")
                      .Options;

        _context = new ApplicationDbContext(options);

        // Seed the in-memory database with some test data
        _context.Products.AddRange(new List<Product>
        {
            new Product { Id = 1, Name = "Sample Product 1", Price = 10.99m, Description = "This is a sample product" },
            new Product { Id = 2, Name = "Sample Product 2", Price = 20.99m, Description = "This is another sample product" }
        });
        _context.SaveChanges();

        _productService = new ProductService(_context);
    }

    [Fact]
    public void GetProducts_ReturnsAllProducts()
    {
        // Act
        var products = _productService.GetProducts();

        // Assert
        Assert.NotNull(products);
        Assert.Equal(2, products.Count());  // Expecting 2 products as per the seeded data
    }
}