﻿using System.Threading.Tasks;
using Pegasus.Command.Shared.Dto;
using Pegasus.Command.Shared.Dto.Account;

namespace Pegasus.Command.CommonUI.Services.Contracts
{
    /// <summary>
    /// Access to User Profile information
    /// </summary>
    public interface IUserProfileApi
    {
        Task<ApiResponseDto> Upsert(UserProfileDto userProfile);
        Task<ApiResponseDto> Get();
    }
}
