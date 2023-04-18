using Newtonsoft.Json;

namespace Nop.Core.Domain.JsonLD
{
    public class JsonLdReview : BaseNopJsonLD
    {
        [JsonProperty("@review")]
        public static string Type => "Review";

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("datePublished")]
        public string DatePublished { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("reviewBody")]
        public string ReviewBody { get; set; }

        [JsonProperty("reviewRating")]
        public JsonLdRating ReviewRating { get; set; }
    }
}