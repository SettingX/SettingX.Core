using System;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace SettingX.Core.Models
{
    public class Network
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
        
        [JsonPropertyName("ips")]
        public string[] Ips => Ip.Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(item => item.Trim()).ToArray();

        public bool IsValidIps()
        {
            return Ips.All(ip => IPAddress.TryParse(ip, out var _) || Regex.IsMatch(ip, @"^[0-9]{1,3}\.[0-9]{0,3}\.?[0-9]{0,3}\.?[0-9]{0,3}$"));
        }
    }
}
