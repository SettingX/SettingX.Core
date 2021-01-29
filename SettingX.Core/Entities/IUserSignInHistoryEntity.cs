using System;

namespace SettingX.Core.Entities
{
    public interface IUserSignInHistoryEntity
    {
        string UserEmail { get; set; }
        DateTime SignInDate { get; set; }
        string IpAddress { get; set; }
    }
}
