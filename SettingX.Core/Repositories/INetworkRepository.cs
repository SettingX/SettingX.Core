using SettingX.Core.Entities;
using SettingX.Core.Models;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface INetworkRepository
    {
        Task<Network[]> GetAllAsync();
        Task<Network> GetByIpAsync(string ip);
        Task<bool> NetworkExistsAsync(string id);
        Task AddAsync(INetwork network);
        Task UpdateAsync(INetwork network);
        Task DeleteAsync(string id);
    }
}
