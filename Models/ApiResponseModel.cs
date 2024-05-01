using System.Text.Json.Serialization;

namespace Blackbaud.AuthCodeFlowTutorial.Models
{
    public class ApiResponseModel
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("value")]
        public ConstituentModel[] Value { get; set; }
    }
}
