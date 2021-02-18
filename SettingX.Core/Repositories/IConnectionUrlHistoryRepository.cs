using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IConnectionUrlHistoricEventsRepository
    {
        Task<(List<ConnectionUrlHistoricEvent>, int)> GetPageAsync(int pageNum, int pageSize);
        Task<List<ConnectionUrlHistoricEvent>> GetByRepositoryIdAsync(string repositoryId);
        Task SaveConnectionUrlHistoricEventAsync(
            string repositoryId,
            string ip,
            string userAgent);
    }
}
