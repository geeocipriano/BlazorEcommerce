using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? categoryUrl = null);
        Task<dynamic> AddProduct(Product product);
        Task<dynamic> DeleteProduct(int productId);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
