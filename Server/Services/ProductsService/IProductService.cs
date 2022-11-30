using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Server.Services.ProductsService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
    }
}
