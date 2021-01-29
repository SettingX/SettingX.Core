using SettingX.Core.Entities;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface IUserActionHistoryRepository
    {
        Task SaveUserActionHistoryAsync(IUserActionHistoryEntity userActionHistory);
    }
}
