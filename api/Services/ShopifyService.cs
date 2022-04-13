using api.Models.Configuration;
using api.Models.Shopify;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace api.Services
{
    public class ShopifyService : IShopifyService
    {
        private readonly HttpClient _httpClient;
        private readonly ShopifyConfiguration _shopifyConfig;

        public ShopifyService(IOptions<ShopifyConfiguration> shopifyConfig)
        {
            _httpClient = new HttpClient();
            _shopifyConfig = shopifyConfig.Value;
            _httpClient.BaseAddress = new Uri(_shopifyConfig.MyShopifyUrl ?? "");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _shopifyConfig.AccessToken);
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync("2022-04/products.json");
            var payload = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var products = JsonConvert.DeserializeObject<ProductListRoot>(payload);
                return products?.Products ?? new List<Product>();
            }

            return new List<Product>();
        }

        public async Task<Product> GetProductById(int id)
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
