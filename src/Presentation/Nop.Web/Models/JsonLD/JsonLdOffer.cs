using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class JsonLdOffer : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "Offer";

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        [JsonProperty("priceValidUntil")]
        public DateTime? PriceValidUntil { get; set; }
    }
}