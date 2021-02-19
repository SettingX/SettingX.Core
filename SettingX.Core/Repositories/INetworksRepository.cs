using System.Collections.Generic;
using SettingX.Core.Models;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface INetworksRepository
    {
        Task<List<Network>> GetAllAsync();
        Task<Network> GetByIpAsync(string ip);
        Task<bool> NetworkExistsAsync(string id);
        Task AddAsync(Network network);
        Task UpdateAsync(Network network);
        Task DeleteAsync(string id);
    }
}
