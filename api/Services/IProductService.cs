using api.Models.Shopify.Products;

namespace api.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();

        Task<Product> GetProductById(int id);

        Task<Product> CreateNewBasicProduct(Product product);
    }
}
