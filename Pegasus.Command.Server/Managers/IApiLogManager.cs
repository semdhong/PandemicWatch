using System;
using System.Threading.Tasks;
using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.DataModels;

namespace Pegasus.Command.Server.Managers
{
    public interface IApiLogManager
    {
        Task Log(ApiLogItem apiLogItem);
        Task<ApiResponse> Get();
        Task<ApiResponse> GetByApplicationUserId(Guid applicationUserId);
    }
}