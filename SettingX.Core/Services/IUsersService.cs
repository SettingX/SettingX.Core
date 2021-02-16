using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Services
{
    public interface IUsersService
    {
        Task CheckInitialAdminAsync();

        Task CreateUserAsync(User user);
    }
}
