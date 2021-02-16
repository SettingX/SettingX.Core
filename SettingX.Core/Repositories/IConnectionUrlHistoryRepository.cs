using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IConnectionUrlHistoricEventsRepository
    {
        Task<(IEnumerable<ConnectionUrlHistoricEvent>, int)> GetPageAsync(int pageNum, int pageSize);
        Task<IEnumerable<ConnectionUrlHistoricEvent>> GetByRepositoryIdAsync(string repositoryId);
        Task SaveConnectionUrlHistoricEventAsync(ConnectionUrlHistoricEvent historicEvent);
    }
}
