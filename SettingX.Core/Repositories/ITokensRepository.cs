using SettingX.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface ITokensRepository
    {
        Task<IToken> GetAsync(string tokenId);
        Task<IToken> GetTopRecordAsync();
        Task<IEnumerable<IToken>> GetAllAsync();
        Task RemoveTokenAsync(string tokenId);
        Task SaveTokenAsync(IToken token);
    }
}
