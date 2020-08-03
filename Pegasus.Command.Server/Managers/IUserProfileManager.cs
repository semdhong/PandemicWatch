using System.Threading.Tasks;
using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.Dto.Account;

namespace Pegasus.Command.Server.Managers
{
    public interface IUserProfileManager
    {
        Task<ApiResponse> Get();
        Task<ApiResponse> Upsert(UserProfileDto userProfile);
        Task<string> GetLastPageVisited(string userName);
    }
}