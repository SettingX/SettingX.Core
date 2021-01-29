using System.Threading.Tasks;
using SettingX.Core.Entities;

namespace SettingX.Core.Services
{
    public interface IUsersService
    {
        Task CheckInitialAdminAsync();

        Task CreateUserAsync(IUserEntity user);
    }
}
