using Pegasus.Models.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Services.Security
{
    public interface IUserService
    {
        IEnumerable<UserModel> GetUsers();
        UserModel GetUser(int id);

        void CreateUser(UserModel model);

        void UpdateUser(UserModel model);

        void RemovePersonProfile(int id);
    }
}
