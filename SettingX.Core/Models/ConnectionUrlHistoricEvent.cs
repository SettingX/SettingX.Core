namespace SettingX.Core.Models
{
    public class ConnectionUrlHistoricEvent
    {
        public string Id { get; set; }
        public string Ip { get; set; }
        public string RepositoryId { get; set; }
        public string UserAgent { get; set; }
        public string Datetime { get; set; }
    }
}