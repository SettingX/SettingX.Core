using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IUserActionHistoryRepository
    {
        Task SaveUserActionHistoryAsync(UserActionHistory userActionHistory);
    }
}
