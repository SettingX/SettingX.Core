using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class ConnectionUrlEventsPagedResult
    {
        [JsonPropertyName("events")]
        public List<ConnectionUrlHistoricEvent> Events { set; get; }
        
        [JsonPropertyName("total")]
        public int Total { set; get; }
    }
}