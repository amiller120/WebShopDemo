using api.Models.Shopify.Products;
using api.Models.ShopifyModels.Products;

namespace api.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();

        Task<Product> GetProductById(long id);

        Task<Product> CreateNewBasicProduct(CreateProductViewModel product);
    }
}
