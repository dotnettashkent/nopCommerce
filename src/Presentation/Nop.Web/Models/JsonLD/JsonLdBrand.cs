using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class JsonLdBrand : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "Brand";

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
