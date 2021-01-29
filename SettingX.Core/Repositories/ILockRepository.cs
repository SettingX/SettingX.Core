using SettingX.Core.Entities;
using System.Threading.Tasks;

namespace SettingX.Core.Repositories
{
    public interface ILockRepository
    {
        Task<ILockEntity> GetJsonPageLockAsync();
        Task SetJsonPageLockAsync(string userEmail, string userName, string ipAddress);
        Task ResetJsonPageLockAsync();
    }
}
