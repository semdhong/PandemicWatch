﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Pegasus.Data
{
    public class ClientSecretsConfiguration : IEntityTypeConfiguration<ClientSecrets>
    {
        public void Configure(EntityTypeBuilder<ClientSecrets> entity)
        {
            entity.HasIndex(e => e.ClientId);
        }
    }
}