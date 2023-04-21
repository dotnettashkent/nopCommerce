using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class JsonLdReview : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "Review";

        [JsonProperty("author")]
        public JsonLdPerson Author { get; set; }

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