using Pegasus.Command.Server.Models;
using Pegasus.Command.Shared.DataInterfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pegasus.Command.Shared.DataModels
{
    public class ApplicationUser : IdentityUser<Guid>//, ITenant
    {
        [MaxLength(64)]
        public string FirstName { get; set; }

        [MaxLength(64)]
        public string LastName { get; set; }

        [MaxLength(64)]
        public string FullName { get; set; }

        public ICollection<ApiLogItem> ApiLogItems { get; set; }

        public UserProfile Profile { get; set; }

        public virtual ICollection<Message> Messages { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
