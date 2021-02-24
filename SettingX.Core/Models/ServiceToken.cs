using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class ServiceToken
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
        
        [JsonPropertyName("security_key_one")]
        public string SecurityKeyOne { get; set; }
        
        [JsonPropertyName("security_key_two")]
        public string SecurityKeyTwo { get; set; }
    }
}