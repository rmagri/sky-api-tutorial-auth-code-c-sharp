using System.Text.Json.Serialization;

namespace Blackbaud.AuthCodeFlowTutorial.Models
{
    public class ConstituentModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("lookup_id")]
        public string LookupId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
