using System;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class RepositoryUpdateHistoricEvent
    {
        [JsonPropertyName("repository_id")]
        public string RepositoryId { get; set; }
        
        [JsonPropertyName("initial_commit")]
        public string InitialCommit { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }
        
        [JsonPropertyName("branch")]
        public string Branch { get; set; }

        [JsonPropertyName("is_manual")]
        public bool IsManual { get; set; }
        
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
    }
}
