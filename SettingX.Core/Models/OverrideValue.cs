using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class OverrideValue
    {
        [JsonPropertyName("network_id")]
        public string NetworkId { get; set; }
        
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
