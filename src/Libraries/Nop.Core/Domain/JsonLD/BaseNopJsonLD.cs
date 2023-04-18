using Newtonsoft.Json;

namespace Nop.Core.Domain.JsonLD
{
    public class BaseNopJsonLD
    {
        [JsonProperty("@context")]
        public static string Context => "https://schema.org";
    }
}
