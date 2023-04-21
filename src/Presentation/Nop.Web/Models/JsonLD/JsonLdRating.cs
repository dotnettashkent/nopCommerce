using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class JsonLdRating : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "Rating";

        [JsonProperty("bestRating")]
        public string BestRating { get; set; }

        [JsonProperty("ratingValue")]
        public int RatingValue { get; set; }

        [JsonProperty("worstRating")]
        public string WorstRating { get; set; }
    }
}