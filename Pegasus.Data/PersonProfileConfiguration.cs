﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pegasus.Data
{
    public class PersonProfileConfiguration : IEntityTypeConfiguration<PersonProfile>
    {
        public void Configure(EntityTypeBuilder<PersonProfile> entity)
        {
            entity.HasOne(d => d.AgentNavigation)
                .WithMany(p => p.PersonProfile)
                .HasForeignKey(d => d.Agent)
                .HasConstraintName("FK_PersonProfile_UserAgents");

            entity.HasOne(d => d.Brgy)
                .WithMany(p => p.PersonProfile)
                .HasForeignKey(d => d.BrgyId)
                .HasConstraintName("FK_PersonProfile_Barangay1");

            entity.HasOne(d => d.IsolationCenterNavigation)
                .WithMany(p => p.PersonProfile)
                .HasForeignKey(d => d.IsolationCenter)
                .HasConstraintName("FK_PersonProfile_IsolationCenters");
        }
    }
}
