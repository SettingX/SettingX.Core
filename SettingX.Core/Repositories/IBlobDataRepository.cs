using SettingX.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface IBlobDataRepository
    {
        Task<string> GetDataAsync(string file = null);
        Task UpdateBlobAsync(string json, string userName, string ipAddress, string file = null);
        Task DelBlobAsync(string file = null);
        Task<bool> ExistsAsync(string file = null);
        Task<List<BlobResult>> GetBlobFilesDataAsync();
        Task<List<string>> GetExistingFileNamesAsync();
    }
}
