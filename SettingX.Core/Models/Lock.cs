using System;

namespace SettingX.Core.Models
{
    public class EditLock
    {
        public string Id { set; get; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string IpAddress { get; set; }
    }
}