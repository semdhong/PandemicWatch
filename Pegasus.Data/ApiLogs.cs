﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pegasus.Data
{
    public partial class ApiLogs
    {
        [Key]
        public long Id { get; set; }
        public DateTime RequestTime { get; set; }
        public long ResponseMillis { get; set; }
        public int StatusCode { get; set; }
        [Required]
        public string Method { get; set; }
        [Required]
        [StringLength(2048)]
        public string Path { get; set; }
        [StringLength(2048)]
        public string QueryString { get; set; }
        [StringLength(256)]
        public string RequestBody { get; set; }
        [StringLength(256)]
        public string ResponseBody { get; set; }
        [StringLength(45)]
        public string IPAddress { get; set; }
        public Guid? ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.ApiLogs))]
        public virtual AspNetUsers ApplicationUser { get; set; }
    }
}