using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IServiceTokenRepository
    {
        Task<List<ServiceToken>> GetAllAsync();
        Task<ServiceToken> GetTopRecordAsync();
        Task<ServiceToken> GetAsync(string tokenKey);
        Task<bool> SaveOrUpdateAsync(ServiceToken token);
        Task<bool> RemoveAsync(string tokenId);
    }
}
