using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IAccountTokenHistoryRepository
    {
        Task SaveTokenHistoryAsync(Token token, string userName, string userIpAddress);
    }
}
