using System.Collections.Generic;
using System.Threading.Tasks;
using Pegasus.Command.Shared.DataModels;
using Pegasus.Command.Shared.Dto.Sample;

namespace Pegasus.Command.Shared.DataInterfaces
{
    public interface IMessageStore
    {
        Task<Message> AddMessage(MessageDto messageDto);

        Task DeleteById(int id);

        List<MessageDto> GetMessages();
    }
}