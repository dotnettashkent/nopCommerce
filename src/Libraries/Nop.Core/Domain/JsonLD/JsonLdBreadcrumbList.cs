using Newtonsoft.Json;

namespace Nop.Core.Domain.JsonLD
{
    public class JsonLdBreadcrumbList : BaseNopJsonLD
    {
        public JsonLdBreadcrumbList()
        {
            ItemListElement = new List<JsonLdBreadcrumbListItem>();
        }

        [JsonProperty("@type")]
        public static string Type => "BreadcrumbList";

        [JsonProperty("itemListElement")]
        public IList<JsonLdBreadcrumbListItem> ItemListElement { get; set; }
    }
}