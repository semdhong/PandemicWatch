﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pegasus.Data
{
    public partial class UserProfiles
    {
        [Key]
        public long Id { get; set; }
        public Guid UserId { get; set; }
        public string LastPageVisited { get; set; }
        public bool IsNavOpen { get; set; }
        public bool IsNavMinified { get; set; }
        public int Count { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(AspNetUsers.UserProfiles))]
        public virtual AspNetUsers User { get; set; }
    }
}