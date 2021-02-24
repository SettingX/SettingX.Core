using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public string Id { set; get; }
        
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
        
        [JsonPropertyName("admin")]
        public bool? Admin { get; set; }
        
        [JsonPropertyName("roles")]
        public string[] Roles { get; set; }
        
        [JsonPropertyName("salt")]
        public string Salt { get; set; }
        
        [JsonPropertyName("password_hash")]
        public string PasswordHash { get; set; }
    }
}