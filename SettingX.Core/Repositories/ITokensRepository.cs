using System.Collections.Generic;
using System.Threading.Tasks;
using SettingX.Core.Models;

namespace SettingX.Core.Repositories
{
    public interface ITokensRepository
    {
        Task<Token> GetAsync(string tokenId);
        Task<Token> GetTopRecordAsync();
        Task<List<Token>> GetAllAsync();
        Task RemoveTokenAsync(string tokenId);
        Task SaveTokenAsync(Token token);
    }
}
