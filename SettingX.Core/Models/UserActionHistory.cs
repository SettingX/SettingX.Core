using System;

namespace SettingX.Core.Models
{
    public class UserActionHistory
    {
        public string UserEmail { get; set; }
        public DateTime ActionDate { get; set; }
        public string IpAddress { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Params { get; set; }
    }
}
