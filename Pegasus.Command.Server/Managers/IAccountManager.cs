using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Pegasus.Command.Shared.DataModels;
using Pegasus.Command.Shared.Dto.Account;

namespace Pegasus.Command.Server.Managers
{
    public interface IAccountManager
    {
        Task<ApiResponse> Login(LoginDto parameters);

        Task<ApiResponse> Register(RegisterDto parameters);

        Task<ApiResponse> ConfirmEmail(ConfirmEmailDto parameters);

        Task<ApiResponse> ForgotPassword(ForgotPasswordDto parameters);

        Task<ApiResponse> ResetPassword(ResetPasswordDto parameters);

        Task<ApiResponse> Logout();

        Task<ApiResponse> UserInfo(ClaimsPrincipal userClaimsPrincipal);

        Task<ApiResponse> UpdateUser(UserInfoDto userInfo);
        
        // Admin policies. 

        Task<ApiResponse> Create(RegisterDto parameters);

        Task<ApiResponse> Delete(string id);

        ApiResponse GetUser(ClaimsPrincipal userClaimsPrincipal);

        Task<ApiResponse> ListRoles();

        Task<ApiResponse> Update(UserInfoDto userInfo);

        Task<ApiResponse> AdminResetUserPasswordAsync(Guid id, string newPassword, ClaimsPrincipal userClaimsPrincipal);
        
        Task<ApplicationUser> RegisterNewUserAsync(string userName, string email, string password, bool requireConfirmEmail);
    }
}
