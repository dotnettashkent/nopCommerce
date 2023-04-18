using Newtonsoft.Json;

namespace Nop.Core.Domain.JsonLD
{
    public class JsonLdBreadcrumbListItem : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "ListItem";

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("item")]
        public JsonLdBreadcrumbItem Item { get; set; }
    }
}