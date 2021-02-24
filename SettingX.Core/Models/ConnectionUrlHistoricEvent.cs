using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class ConnectionUrlHistoricEvent
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
        
        [JsonPropertyName("repository_id")]
        public string RepositoryId { get; set; }
        
        [JsonPropertyName("user_agent")]
        public string UserAgent { get; set; }
        
        [JsonPropertyName("date_time")]
        public string Datetime { get; set; }
    }
}