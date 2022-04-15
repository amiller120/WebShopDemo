using api.Models.Configuration;
using api.Models.Shopify.Products;
using api.Models.ShopifyModels.Products;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using System.Text;

namespace api.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private readonly ShopifyConfiguration _shopifyConfig;

        public ProductService(IOptions<ShopifyConfiguration> shopifyConfig)
        {
            _httpClient = new HttpClient();
            _shopifyConfig = shopifyConfig.Value;
            _httpClient.BaseAddress = new Uri($"{_shopifyConfig.MyShopifyUrl}/admin/api/{_shopifyConfig.Version}/" ?? "");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("X-Shopify-Access-Token", _shopifyConfig.AccessToken);
        }

        public async Task<List<Product>> GetProducts()
        {
            var response = await _httpClient.GetAsync("products.json");
            var payload = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var products = JsonConvert.DeserializeObject<ProductListRoot>(payload);
                return products?.Products ?? new List<Product>();
            }

            return new List<Product>();
        }

        public async Task<Product> GetProductById(long id)
        {
            var response = await _httpClient.GetAsync($"products/{id}");
            var payload = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                var productRoot = JsonConvert.DeserializeObject<ProductRoot>(payload);
                return productRoot?.Product ?? new Product();
            }

            return new Product();
        }

        public async Task<Product> CreateNewBasicProduct(Product product)
        {
            var productRequest = new Product()
            {
                id = product.id,
                title = product.title,
                body_html = product.body_html,
                product_type = product.product_type,
                vendor = product.vendor
            };

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };

            var jsonContent = JsonConvert.SerializeObject(productRequest,
                Formatting.None,
                new JsonSerializerSettings
                {
                    ContractResolver = contractResolver,
                    NullValueHandling = NullValueHandling.Ignore
                });

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(new Uri("products.json"), content).ConfigureAwait(false);
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var responseObject = JsonConvert.DeserializeObject<Product>(responseBody);

            if(responseObject != null)
            {
                return responseObject;
            }
            return new Product();
        }
    }
}

