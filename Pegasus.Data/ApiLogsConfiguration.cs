﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Pegasus.Data
{
    public class ApiLogsConfiguration : IEntityTypeConfiguration<ApiLogs>
    {
        public void Configure(EntityTypeBuilder<ApiLogs> entity)
        {
            entity.HasIndex(e => e.ApplicationUserId);
        }
    }
}