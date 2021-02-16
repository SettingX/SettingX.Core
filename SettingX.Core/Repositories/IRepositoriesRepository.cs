using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IRepositoriesRepository
    {
        Task<Repository> GetAsync(string repositoryId);
        Task<IEnumerable<Repository>> GetAllAsync();
        Task RemoveRepositoryAsync(string repositoryId);
        Task SaveRepositoryAsync(Repository repository);
        Task<IEnumerable<Repository>> GetAsync(Func<Repository, bool> filter);
    }
}
