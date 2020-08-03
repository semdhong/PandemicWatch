using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.Dto.Tenant;
using System.Threading.Tasks;

namespace Pegasus.Command.Server.Managers
{
    public interface ITenantManager
    {
        Task<ApiResponse> Get();

        Task<ApiResponse> Get(int id);

        Task<ApiResponse> Create(TenantDto tenant);

        Task<ApiResponse> Update(TenantDto tenant);

        Task<ApiResponse> Delete(int id);
    }
}
