using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface IKeyValuesRepository
    {
        Task<Dictionary<string, KeyValue>> GetAsync();
        Task<KeyValue> GetTopRecordAsync();
        Task<IEnumerable<KeyValue>> GetAsync(Func<KeyValue, bool> filter);
        Task<IEnumerable<KeyValue>> GetKeyValuesAsync();
        Task<IEnumerable<KeyValue>> GetKeyValuesAsync(Func<KeyValue, bool> filter, string repositoryId = null);
        Task<KeyValue> GetKeyValueAsync(string key);
        Task<Dictionary<string, KeyValue>> GetKeyValuesAsync(IEnumerable<string> keys);
        Task<bool> UpdateKeyValueAsync(IEnumerable<KeyValue> keyValueList);
        Task<bool> ReplaceKeyValueAsync(IEnumerable<KeyValue> keyValueList);
        Task RemoveNetworkOverridesAsync(string networkId);
        Task DeleteKeyValueWithHistoryAsync(
            string keyValueId,
            string description,
            string userName,
            string userIpAddress);
    }
}
