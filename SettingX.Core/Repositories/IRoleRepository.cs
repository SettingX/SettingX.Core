using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IRoleRepository
    {
        Task<Role> GetAsync(string roleId);
        Task<List<Role>> GetAllAsync();
        Task<List<Role>> GetAllAsync(Func<Role, bool> filter);
        Task SaveAsync(Role entity);
        Task RemoveAsync(string roleId);
    }
}
