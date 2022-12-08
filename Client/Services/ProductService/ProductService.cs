using BlazorEcommerce.Shared;
using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}")
                ;
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }
            ProductsChanged.Invoke();
        }

        public void AddProduct(Product produto)
        {
            _http.PostAsJsonAsync("api/product", produto);
        }

        public void DeleteProduct(int productId)
        {
            _http.DeleteAsync($"api/product/{productId}");
        }
    }
}
