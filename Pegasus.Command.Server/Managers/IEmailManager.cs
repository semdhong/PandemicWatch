using System.Collections.Generic;
using System.Threading.Tasks;
using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared;
using Pegasus.Command.Shared.Dto;
using Pegasus.Command.Shared.Dto.Email;

namespace Pegasus.Command.Server.Managers
{
    public interface IEmailManager
    {
        Task<ApiResponse> Send(EmailDto parameters);
        Task<ApiResponse> Receive();
        Task<ApiResponse> SendEmailAsync(EmailMessageDto emailMessage);
        List<EmailMessageDto> ReceiveEmail(int maxCount = 10);
        Task<ApiResponse> ReceiveMailImapAsync();
        Task<ApiResponse> ReceiveMailPopAsync(int min = 0, int max = 0);
        void Send(EmailMessageDto emailMessage);
    }
}