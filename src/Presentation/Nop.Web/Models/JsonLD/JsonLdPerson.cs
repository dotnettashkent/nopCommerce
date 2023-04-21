using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class JsonLdPerson : BaseNopJsonLD
    {
        [JsonProperty("@type")]
        public static string Type => "Person";

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
