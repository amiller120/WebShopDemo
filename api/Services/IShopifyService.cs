using api.Models.Shopify;

namespace api.Services
{
    public interface IShopifyService
    {
        Task<List<Product>> GetProducts();

        Task<Product> GetProductById(int id);
    }
}
