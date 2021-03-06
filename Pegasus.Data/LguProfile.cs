﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pegasus.Data
{
    public partial class LguProfile
    {
        public LguProfile()
        {
            Barangay = new HashSet<Barangay>();
        }

        [Key]
        public int Id { get; set; }
        [Column(TypeName = "text")]
        public string LguName { get; set; }
        [Column(TypeName = "text")]
        public string LguAddress { get; set; }
        [Column(TypeName = "text")]
        public string LguLocation { get; set; }
        [Column(TypeName = "text")]
        public string LguLogoPath { get; set; }
        [Column(TypeName = "text")]
        public string LguQrCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }

        [InverseProperty("Lgu")]
        public virtual ICollection<Barangay> Barangay { get; set; }
    }
}