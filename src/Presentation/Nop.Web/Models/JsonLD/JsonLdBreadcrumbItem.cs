using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class JsonLdBreadcrumbItem : BaseNopJsonLD
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}