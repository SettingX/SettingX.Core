using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class Repository
    {
        [JsonPropertyName("repository_id")]
        public string RepositoryId { get; set; }
        
        [JsonPropertyName("last_modified")]
        public string LastModified { get; set; }
        
        [JsonPropertyName("name")]
        public string Name { get; set; }
        
        [JsonPropertyName("git_url")]
        public string GitUrl { get; set; }
        
        [JsonPropertyName("branch")]
        public string Branch { get; set; }
        
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
        
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
        
        [JsonPropertyName("connection_url")]
        public string ConnectionUrl { get; set; }
        
        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; }
        
        [JsonPropertyName("use_manual_settings")]
        public bool UseManualSettings { get; set; }
        
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}
