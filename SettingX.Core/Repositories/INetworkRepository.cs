using SettingX.Core.Models;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface INetworkRepository
    {
        Task<Network[]> GetAllAsync();
        Task<Network> GetByIpAsync(string ip);
        Task<bool> NetworkExistsAsync(string id);
        Task AddAsync(Network network);
        Task UpdateAsync(Network network);
        Task DeleteAsync(string id);
    }
}
