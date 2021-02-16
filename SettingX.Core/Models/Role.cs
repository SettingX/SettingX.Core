namespace SettingX.Core.Models
{
    public class Role
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        public RoleKeyValue[] KeyValues { get; set; }
    }
}