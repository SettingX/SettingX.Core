using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class RoleKeyValue
    {
        [JsonPropertyName("row_key")]
        public string RowKey { get; set; }
        
        [JsonPropertyName("has_full_access")]
        public bool HasFullAccess { get; set; }
    }
}