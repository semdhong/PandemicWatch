using Pegasus.Command.Shared.DataModels;
using Pegasus.Command.Shared.Dto.Sample;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pegasus.Command.Shared.DataInterfaces
{
    public interface IToDoStore
    {
        Task<List<TodoDto>> GetAll();

        Task<TodoDto> GetById(long id);

        Task<Todo> Create(TodoDto todoDto);

        Task<Todo> Update(TodoDto todoDto);

        Task DeleteById(long id);
    }
}