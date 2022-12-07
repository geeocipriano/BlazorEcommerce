namespace BlazorEcommerce.Server.Services.ProductsService
{
    public interface IProductService
    {
        #region Metodos
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
        Task<ServiceResponse<List<Product>>> AddProductAsync(Product product);
        Task<ServiceResponse<List<Product>>> DeleteProductAsync(int productId);
        #endregion
    }
}
