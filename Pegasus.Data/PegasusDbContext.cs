﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Pegasus.Data
{
    public partial class PegasusDbContext : DbContext
    {
        public PegasusDbContext()
        {
        }

        public PegasusDbContext(DbContextOptions<PegasusDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barangay> Barangay { get; set; }
        public virtual DbSet<IsolationCenters> IsolationCenters { get; set; }
        public virtual DbSet<LguProfile> LguProfile { get; set; }
        public virtual DbSet<PersonHistory> PersonHistory { get; set; }
        public virtual DbSet<PersonProfile> PersonProfile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BarangayConfiguration());
            modelBuilder.ApplyConfiguration(new PersonHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new PersonProfileConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
