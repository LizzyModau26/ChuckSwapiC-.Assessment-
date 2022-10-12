using Newtonsoft.Json;

namespace Sovtech.Assessment.Models
{
    [JsonObject]
    public class People
    {

        [JsonProperty]
        public string? Name { get; set; }

        [JsonProperty]
        public int? Height { get; set; }

        [JsonProperty]
        public int? Mass { get; set; }

        [JsonProperty]
        public string? Hair_color { get; set; }

        [JsonProperty]
        public string? Skin_color { get; set; }

        [JsonProperty]
        public string? Eye_color { get; set; }

        [JsonProperty]
        public string? Birth_year { get; set; }

        [JsonProperty]
        public string? Gender { get; set; }

        [JsonProperty]
        public Uri? Homeworld { get; set; }


    }
}

