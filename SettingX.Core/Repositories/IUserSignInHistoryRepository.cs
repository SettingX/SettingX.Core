using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IUserSignInHistoryRepository
    {
        Task SaveUserLoginHistoryAsync(User user, string userIpAddress);
    }
}
