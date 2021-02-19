using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IRepositoriesRepository
    {
        Task<Repository> GetAsync(string repositoryId);
        Task<List<Repository>> GetAllAsync();
        Task RemoveRepositoryAsync(string repositoryId);
        Task SaveRepositoryAsync(Repository repository);
    }
}
