using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace api.Enumerations.ShopifyEnums.Products
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status : byte
    {
        active = 1,
        draft = 2,
        archive = 3
    }
}
