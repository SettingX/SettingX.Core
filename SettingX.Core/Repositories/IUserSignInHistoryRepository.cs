using SettingX.Core.Entities;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface IUserSignInHistoryRepository
    {
        Task SaveUserLoginHistoryAsync(IUserEntity user, string userIpAddress);
    }
}
