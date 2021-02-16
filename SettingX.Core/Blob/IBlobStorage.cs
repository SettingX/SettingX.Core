using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Blob
{
    public interface IBlobStorage
    {
        Task SaveBlobAsync(string container, string key, Stream bloblStream);

        Task SaveBlobAsync(string container, string key, byte[] blob);

        Task<bool> HasBlobAsync(string container, string key);

        Task<BlobResult> GetAsync(string blobContainer, string key);

        Task<IEnumerable<BlobResult>> GetBlobFilesDataAsync(string container);

        Task<List<string>> GetExistingFileNames(string container);

        Task DelBlobAsync(string blobContainer, string key);
    }
}