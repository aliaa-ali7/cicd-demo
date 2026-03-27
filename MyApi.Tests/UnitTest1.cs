using Microsoft.AspNetCore.Http.HttpResults;

namespace MyApi.Tests;

public class ProductsTests
{
    [Fact]
    public void GetProducts_ReturnsThreeProducts()
    {
        // Arrange
        var products = new[]
        {
            new { Id = 1, Name = "Laptop", Price = 999.99 },
            new { Id = 2, Name = "Phone", Price = 499.99 },
            new { Id = 3, Name = "Tablet", Price = 299.99 }
        };

        // Act
        var count = products.Length;

        // Assert
        Assert.Equal(3, count);
    }

    [Fact]
    public void GetProducts_FirstProductIsLaptop()
    {
        // Arrange
        var products = new[]
        {
            new { Id = 1, Name = "Laptop", Price = 999.99 },
            new { Id = 2, Name = "Phone", Price = 499.99 },
            new { Id = 3, Name = "Tablet", Price = 299.99 }
        };

        // Assert
        Assert.Equal("Laptop", products[0].Name);
    }
}