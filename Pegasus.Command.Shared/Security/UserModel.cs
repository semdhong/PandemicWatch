using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Command.Shared.Security
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public UserRoleModel Role { get; set; }
        public int? RoleId { get; set; }
        public string ConfirmPassword { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
