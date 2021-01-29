using SettingX.Core.Entities;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface IServiceTokenHistoryRepository
    {
        Task SaveTokenHistoryAsync(IServiceTokenEntity token, string userName, string userIpAddress);
    }
}
