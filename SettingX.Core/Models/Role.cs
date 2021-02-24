using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class Role
    {
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("key_value")]
        public RoleKeyValue[] KeyValues { get; set; }
    }
}