﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IRepositoryUpdateHistoryEventsRepository
    {
        Task<RepositoryUpdateHistoricEvent> GetAsync(string repositoryUpdateHistoryId);
        Task SaveRepositoryUpdateHistoryAsync(RepositoryUpdateHistoricEvent entity);
        Task<List<RepositoryUpdateHistoricEvent>> GetByInitialCommitAsync(string initialCommit);
        Task RemoveRepositoryUpdateHistoryAsync(List<string> repositoryUpdateHistoryIds);
    }
}
