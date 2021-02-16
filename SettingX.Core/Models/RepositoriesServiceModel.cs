using System.Collections.Generic;
using SettingX.Core.Enums;

namespace SettingX.Core.Models
{
    public class RepositoriesServiceModel
    {
        public UpdateSettingsStatus Result { get; set; }
        
        public string Message { get; set; }
        
        public string Json { get; set; }
        
        public object Data { get; set; }
        
        public IEnumerable<object> CollectionData { get; set; }
    }
}
