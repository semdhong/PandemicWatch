using System.Threading.Tasks;
using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.Dto;
using Pegasus.Command.Shared.Dto.Admin;
using Microsoft.AspNetCore.Mvc;

namespace Pegasus.Command.Server.Managers
{
    public interface IAdminManager
    {
        Task<ApiResponse> GetUsers(int pageSize = 10, int pageNumber = 0);

        ApiResponse GetPermissions();

        Task<ApiResponse> GetRoles(int pageSize = 10,int pageNumber = 0);

        Task<ApiResponse> GetRoleAsync(string roleName);

        Task<ApiResponse> CreateRoleAsync(RoleDto newRole);

        Task<ApiResponse> UpdateRoleAsync([FromBody] RoleDto newRole);

        Task<ApiResponse> DeleteRoleAsync(string name);

    }
}
