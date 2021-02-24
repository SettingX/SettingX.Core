using System;
using System.Text.Json.Serialization;

namespace SettingX.Core.Models
{
    public class KeyValue
    {
        [JsonPropertyName("key_value_id")]
        public string KeyValueId { get; set; }
        
        [JsonPropertyName("value")]
        public string Value { get; set; }
        
        [JsonPropertyName("overrides")]
        public OverrideValue[] Override { get; set; } = Array.Empty<OverrideValue>();
        
        [JsonPropertyName("types")]
        public string[] Types { get; set; }
        
        [JsonPropertyName("is_duplicated")]
        public bool? IsDuplicated { get; set; }
        
        [JsonPropertyName("use_not_tagged_value")]
        public bool? UseNotTaggedValue { get; set; }
        
        [JsonPropertyName("repository_names")]
        public string[] RepositoryNames { get; set; }
        
        [JsonPropertyName("repository_id")]
        public string RepositoryId { get; set; }
        
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
        
        [JsonPropertyName("empty_value_type")]
        public string EmptyValueType { get; set; }
    }
}
