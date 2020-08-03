﻿using AutoMapper;
using Pegasus.Command.Shared.DataInterfaces;
using Pegasus.Command.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pegasus.Command.Storage.Stores
{
    public class ApiLogStore : IApiLogStore
    {
        private readonly IApplicationDbContext _db;
        private readonly IMapper _autoMapper;

        public ApiLogStore(IApplicationDbContext db, IMapper autoMapper)
        {
            _db = db;
            _autoMapper = autoMapper;
        }

        public async Task<List<ApiLogItemDto>> Get()
            => await _autoMapper.ProjectTo<ApiLogItemDto>(_db.ApiLogs).ToListAsync();

        public async Task<List<ApiLogItemDto>> GetByUserId(Guid userId)
        => await _autoMapper.ProjectTo<ApiLogItemDto>(_db.ApiLogs.Where(a => a.ApplicationUserId == userId)).ToListAsync();
    }
}