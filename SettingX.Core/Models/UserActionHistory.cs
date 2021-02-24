using System;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class UserActionHistory
    {
        [JsonPropertyName("user_email")]
        public string UserEmail { get; set; }
        
        [JsonPropertyName("action_date")]
        public DateTime ActionDate { get; set; }
        
        [JsonPropertyName("ip_address")]
        public string IpAddress { get; set; }
        
        [JsonPropertyName("controller_name")]
        public string ControllerName { get; set; }
        
        [JsonPropertyName("action_name")]
        public string ActionName { get; set; }
        
        [JsonPropertyName("params")]
        public string Params { get; set; }
    }
}
