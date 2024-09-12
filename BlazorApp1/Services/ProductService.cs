using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp1.Shared;

namespace BlazorApp1.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Product[]> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Product[]>("products");
        }
    }
}
