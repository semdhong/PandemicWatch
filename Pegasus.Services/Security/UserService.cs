using Pegasus.Data;
using Pegasus.Models.Security;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pegasus.Services.Security
{
    public class UserService : IUserService
    {
        private readonly IRepository<Users> _repoUsers;
        public UserService(IRepository<Users> repoUsers)
        {
            _repoUsers = repoUsers;
        }
        public void CreateUser(UserModel model)
        {
            _repoUsers.AddAsync(new Users
            {
                Firstname = model.FirstName,
                Lastname = model.LastName,
                EmailAddress = model.EmailAddress,
                ContactNo = model.ContactNo,
                Password = model.Password,
                RoleId = model.RoleId,
                Username = model.Username,
               
            });
        }

        public UserModel GetUser(int id)
        {
            return _repoUsers.GetAll().Select(x => new UserModel
            {
                UserId =x.UserId,
                FirstName = x.Firstname,
                LastName = x.Lastname,
                EmailAddress = x.EmailAddress,
                ContactNo = x.ContactNo,
                Password = x.Password,
                Role = new UserRoleModel { RoleId = x.Role.RoleId, RoleDesc = x.Role.RoleDescription },
                Username = x.Username,
            }).FirstOrDefault(x=>x.UserId==id);
        }

        public IEnumerable<UserModel> GetUsers()
        {
            return _repoUsers.GetAll().Select(x => new UserModel
            {
                UserId = x.UserId,
                FirstName = x.Firstname,
                LastName = x.Lastname,
                EmailAddress = x.EmailAddress,
                ContactNo = x.ContactNo,
                Password = x.Password,
                Role = new UserRoleModel { RoleId = x.Role.RoleId, RoleDesc = x.Role.RoleDescription },
                Username = x.Username,
            });
        }

        public void RemovePersonProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserModel model)
        {
            _repoUsers.UpdateAsync(new Users
            {
                Firstname = model.FirstName,
                Lastname = model.LastName,
                EmailAddress = model.EmailAddress,
                ContactNo = model.ContactNo,
                Password = model.Password,
                RoleId = model.RoleId,
                Username = model.Username,

            });
        }
    }
}
