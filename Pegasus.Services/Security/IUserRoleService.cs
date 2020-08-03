using Pegasus.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Services.Security
{
    public interface IUserRoleService
    {
        IEnumerable<UserRoleModel> GetRoles();
        UserRoleModel GetRole(int id);

        void CreateRole(UserRoleModel model);

        void UpdateRole(UserRoleModel model);

      
    }
}
