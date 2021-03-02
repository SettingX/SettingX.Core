using System;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class KeyValueHistoricEvent
    {
        [JsonPropertyName("id")]
        public string Id { set; get; }
        
        [JsonPropertyName("key_value_id")]
        public string KeyValueId { get; set; }
        
        [JsonPropertyName("date_time")]
        public DateTime DateTime { get; set; }
        
        [JsonPropertyName("new_value")]
        public string NewValue { get; set; }
        
        [JsonPropertyName("new_override")]
        public string NewOverride { get; set; }
        
        [JsonPropertyName("key_values_snapshot")]
        public string KeyValuesSnapshot { get; set; }
        
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
        
        [JsonPropertyName("user_ip_address")]
        public string UserIpAddress { get; set; }
    }
}