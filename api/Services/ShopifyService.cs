using api.Models;
using api.Models.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Text;

namespace api.Services
{
    public class ShopifyService : IShopifyService
    {
        private readonly HttpClient _httpClient;
        private readonly ShopifyConfiguration _shopifyConfig;

        public ShopifyService(HttpClient httpClient,
                              IOptions<ShopifyConfiguration> shopifyConfig)
        {
            _httpClient = httpClient;
            _shopifyConfig = shopifyConfig.Value;
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync("products");
            var payload = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(payload);
                return products ?? new List<Product>();
            }

            return new List<Product>();
        }

        public async Task<Product> GetProduct(int id)
        {
            var response = await _httpClient.GetAsync($"product/{id}");
            var payload = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var product = JsonConvert.DeserializeObject<Product>(payload);
                return product ?? new Product();
            }

            return new Product();
        }
    }
}
