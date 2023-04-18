using Newtonsoft.Json;

namespace Nop.Core.Domain.JsonLD
{
    public class JsonLdAggregateRating : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "AggregateRating";

        [JsonProperty("ratingValue")]
        public string RatingValue { get; set; }

        [JsonProperty("reviewCount")]
        public int ReviewCount { get; set; }
    }
}