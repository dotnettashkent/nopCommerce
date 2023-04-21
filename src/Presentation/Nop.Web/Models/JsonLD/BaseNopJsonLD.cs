using Newtonsoft.Json;

namespace Nop.Web.Models.JsonLD
{
    public class BaseNopJsonLD
    {
        [JsonProperty("@context")]
        public static string Context => "https://schema.org";
    }
}
