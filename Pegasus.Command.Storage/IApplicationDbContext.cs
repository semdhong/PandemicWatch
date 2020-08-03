﻿using Pegasus.Command.Server.Models;
using Pegasus.Command.Shared.DataInterfaces;
using Pegasus.Command.Shared.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Pegasus.Command.Storage
{
    public interface IApplicationDbContext
    {
        public DbSet<ApiLogItem> ApiLogs { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        //public DbSet<Tenant> Tenants { get; set; }

        public void SetGlobalQueryForSoftDelete<T>(ModelBuilder builder) where T : class, ISoftDelete;

        public void SetGlobalQueryForSoftDeleteAndTenant<T>(ModelBuilder builder) where T : class, ISoftDelete, ITenant;

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        int SaveChanges();

    }
}
