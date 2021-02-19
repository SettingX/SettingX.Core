using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IKeyValueHistoryRepository
    {
        Task SaveKeyValueHistoryAsync(
            string keyValueId,
            string newValue,
            string keyValues,
            string userName,
            string userIpAddress);

        Task SaveKeyValuesHistoryAsync(
            List<KeyValue> keyValues,
            string userName,
            string userIpAddress);

        Task SaveKeyValueOverrideHistoryAsync(
            string keyValueId,
            string newOverride,
            string keyValues,
            string userName,
            string userIpAddress);

        Task DeleteKeyValueHistoryAsync(
            string keyValueId,
            string description,
            string userName,
            string userIpAddress);

        Task<List<KeyValueHistoricEvent>> GetHistoryByKeyValueAsync(string keyValueId);
    }
}
