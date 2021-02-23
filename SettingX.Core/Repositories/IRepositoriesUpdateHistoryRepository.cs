using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IRepositoryUpdateHistoryEventsRepository
    {
        Task<RepositoryUpdateHistoricEvent> GetAsync(string initialCommit);
        Task SaveRepositoryUpdateHistoryAsync(RepositoryUpdateHistoricEvent entity);
        Task<List<RepositoryUpdateHistoricEvent>> GetAsyncByInitialCommitAsync(string initialCommit);
        Task RemoveRepositoryUpdateHistoryAsync(List<string> repositoryUpdateHistoryIds);
    }
}
