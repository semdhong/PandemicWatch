﻿using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.DataInterfaces;
using Pegasus.Command.Shared.Dto.Sample;
using static Microsoft.AspNetCore.Http.StatusCodes;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pegasus.Command.Server.Managers
{
    public class MessageManager : IMessageManager
    {
        private readonly IMessageStore _messageStore;
        private readonly ILogger<MessageManager> _logger;

        public MessageManager(IMessageStore messageStore, ILogger<MessageManager> logger)
        {
            _messageStore = messageStore;
            _logger = logger;
        }

        public async Task<ApiResponse> Create(MessageDto messageDto)
        {
            _logger.LogDebug("Adding message: {@messageDto}", messageDto);
            var message = await _messageStore.AddMessage(messageDto);
            return new ApiResponse(Status200OK, "Created Message", message);
        }

        public async Task<ApiResponse> Delete(int id)
        {
            await _messageStore.DeleteById(id);
            return new ApiResponse(Status200OK, "Deleted Message", id);
        }

        public List<MessageDto> GetList()
        {
            return _messageStore.GetMessages();
        }
    }
}
