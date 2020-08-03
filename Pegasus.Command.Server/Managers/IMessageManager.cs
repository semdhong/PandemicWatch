using System.Collections.Generic;
using System.Threading.Tasks;
using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.Dto;
using Pegasus.Command.Shared.Dto.Sample;

namespace Pegasus.Command.Server.Managers
{
    public interface IMessageManager
    {
        Task<ApiResponse> Create(MessageDto messageDto);
        List<MessageDto> GetList();
        Task<ApiResponse> Delete(int id);
    }
}