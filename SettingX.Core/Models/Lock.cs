using System;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class EditLock
    {
        [JsonPropertyName("id")]
        public string Id { set; get; }
        
        [JsonPropertyName("date_time")]
        public DateTime DateTime { get; set; }
        
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
        
        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }
        
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }
    }
}