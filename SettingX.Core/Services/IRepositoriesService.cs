using SettingX.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SettingX.Core.Services
{
    public interface IRepositoriesService
    {
        Task<RepositoriesServiceModel> CreateRepositoryAsync(
            Repository repository,
            string userName,
            string userIp,
            string userEmail,
            bool isProduction);

        Task<RepositoriesServiceModel> UpdateRepositoryAsync(
            Repository repository,
            string userName,
            string userIp,
            string userEmail,
            bool isProduction,
            string search = null);

        Task<string> GetFileData(string file);

        Task AddToHistoryRepository(
            Repository repository,
            string settingsJson,
            string lastCommit = "",
            bool isManual = false,
            string userName = "",
            string userIp = "");

        Task<List<Repository>> GetAllRepositories();

        Task<RepositoriesServiceModel> GetPaginatedRepositories(string search = "", int? page = 1);

        Task<bool> SaveKeyValuesAsync(IEnumerable<KeyValue> keyValues, string userEmail, string userIp, bool isProduction);
    }
}
