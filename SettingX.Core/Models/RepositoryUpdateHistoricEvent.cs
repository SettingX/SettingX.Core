using System;

namespace SettingX.Core.Models
{
    public class RepositoryUpdateHistoricEvent
    {
        public string Id { set; get; }
        
        public string RepositoryId { get; set; }

        public string InitialCommit { get; set; }

        public string User { get; set; }

        public string Branch { get; set; }

        public bool IsManual { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}
