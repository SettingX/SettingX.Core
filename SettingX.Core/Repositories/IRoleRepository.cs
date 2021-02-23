﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IRoleRepository
    {
        Task<Role> GetAsync(string roleId);
        Task<Role> GetByNameAsync(string roleName);
        Task<List<Role>> GetAllAsync();
        Task<List<Role>> FindAsync(List<string> roleIds);
        Task SaveAsync(Role entity);
        Task RemoveAsync(string roleId);
    }
}
