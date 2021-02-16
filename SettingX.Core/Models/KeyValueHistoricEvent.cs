namespace SettingX.Core.Models
{
    public class KeyValueHistoricEvent
    {
        public string Id { set; get; }
        public string KeyValueId { get; set; }
        public string NewValue { get; set; }
        public string NewOverride { get; set; }
        public string KeyValuesSnapshot { get; set; }
        public string UserName { get; set; }
        public string UserIpAddress { get; set; }
    }
}