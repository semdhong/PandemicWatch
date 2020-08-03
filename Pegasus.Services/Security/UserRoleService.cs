using Pegasus.Data;
using Pegasus.Models.Security;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pegasus.Services.Security
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IRepository<UserRole> _repoUserRole;
        public UserRoleService(IRepository<UserRole> repoUserRole)
        {
            _repoUserRole = repoUserRole;
        }

        public void CreateRole(UserRoleModel model)
        {
             _repoUserRole.AddAsync(new UserRole
            {
                RoleId = model.RoleId,
                RoleDescription = model.RoleDesc
            });
            
        }

        public UserRoleModel GetRole(int id)
        {
            return _repoUserRole.GetAll().Select(x => new UserRoleModel
            {
                RoleId = x.RoleId,
                RoleDesc = x.RoleDescription
            }).FirstOrDefault(x=>x.RoleId==id);
        }

        public IEnumerable<UserRoleModel> GetRoles()
        {
            return _repoUserRole.GetAll().Select(x => new UserRoleModel
            {
                RoleId = x.RoleId,
                RoleDesc = x.RoleDescription
            });

        }

        public void UpdateRole(UserRoleModel model)
        {
            _repoUserRole.UpdateAsync(new UserRole
            {
                RoleId = model.RoleId,
                RoleDescription = model.RoleDesc
            });
        }
    }
}
