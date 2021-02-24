using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class Token
    {
        [JsonPropertyName("token_id")]
        public string TokenId { set; get; }
        
        [JsonPropertyName("ip_list")]
        public string IpList { get; set; }
        
        [JsonPropertyName("access_list")]
        public string AccessList { get; set; }
    }
}