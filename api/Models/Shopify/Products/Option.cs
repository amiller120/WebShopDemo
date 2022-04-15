namespace api.Models.Shopify.Products
{
    public class Option
    {
        public long product_id { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public List<string> values { get; set; }
    }
}
