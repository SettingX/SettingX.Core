namespace SettingX.Core.Models
{
    public class User
    {
        public string Id { set; get; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Active { get; set; }
        public bool? Admin { get; set; }
        public string[] Roles { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }
    }
}