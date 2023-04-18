using Newtonsoft.Json;

namespace Nop.Core.Domain.JsonLD
{
    public class JsonLdProduct : BaseNopJsonLD
    {
        public JsonLdProduct()
        {
            IsSimilarTo = new List<JsonLdProduct>();
            Brand = new List<JsonLdBrand>();
            Review = new List<JsonLdReview>();
        }

        [JsonProperty("@type")]
        public static string Type => "Product";

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Offers")]
        public JsonLdOffer Offer { get; set; }

        [JsonProperty("aggregateRating")]
        public JsonLdAggregateRating AggregateRating { get; set; }

        [JsonProperty("review")]
        public IList<JsonLdReview> Review { get; set; }

        [JsonProperty("isSimilarTo")]
        public IList<JsonLdProduct> IsSimilarTo { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("mpn")]
        public string Mpn { get; set; }

        [JsonProperty("description")]

        public string Description { get; set; }

        [JsonProperty("image")]

        public string Image { get; set; }

        public IList<JsonLdBrand> Brand { get; set; }
    }
}