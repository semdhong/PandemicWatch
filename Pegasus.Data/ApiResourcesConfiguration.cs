﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Pegasus.Data
{
    public class ApiResourcesConfiguration : IEntityTypeConfiguration<ApiResources>
    {
        public void Configure(EntityTypeBuilder<ApiResources> entity)
        {
            entity.HasIndex(e => e.Name)
                .IsUnique();
        }
    }
}
