using SettingX.Core.Entities;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface IAccountTokenHistoryRepository
    {
        Task SaveTokenHistoryAsync(IToken token, string userName, string userIpAddress);
    }
}
