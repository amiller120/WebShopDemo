namespace api.Models.ShopifyModels.Products
{
    public class ProductImage
    {
        public DateTime Created_At { get; set; }
        public long Id { get; set; }
        public int Position { get; set; }
        public List<int> Variant_Ids { get; set; }
        public string Src { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTime Updated_At { get; set; }

    }
}
