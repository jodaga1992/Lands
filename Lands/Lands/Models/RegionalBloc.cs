using Newtonsoft.Json;

namespace Lands.Models
{
    class RegionalBloc
    {
        [JsonProperty(PropertyName = "acronym")]
        public string Acronym { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
