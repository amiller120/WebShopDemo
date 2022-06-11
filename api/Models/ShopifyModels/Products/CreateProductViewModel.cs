using api.Models.Shopify.Products;

namespace api.Models.ShopifyModels.Products
{
    public class CreateProductViewModel
    {
        
        public string Title { get; set; }
        public string Body_html { get; set; }
        public string Product_type { get; set; }
        public string Status { get; set; }
        public string Tags { get; set; }
        public IFormFile Image { get; set; }
    }
}