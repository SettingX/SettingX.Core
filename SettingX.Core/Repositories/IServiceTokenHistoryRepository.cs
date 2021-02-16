using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IServiceTokenHistoryRepository
    {
        Task SaveTokenHistoryAsync(ServiceToken token, string userName, string userIpAddress);
    }
}
