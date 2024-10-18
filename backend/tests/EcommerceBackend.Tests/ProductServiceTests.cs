using EcommerceBackend.Core.Interfaces;
using EcommerceBackend.Services;
using Xunit;

public class ProductServiceTests
{
    private readonly IProductService _productService;

    public ProductServiceTests()
    {
        _productService = new ProductService();
    }

    [Fact]
    public void GetProducts_ReturnsAllProducts()
    {
        // Act
        var products = _productService.GetProducts();

        // Assert
        Assert.NotNull(products);
        Assert.Equal(3, products.Count());
    }
}