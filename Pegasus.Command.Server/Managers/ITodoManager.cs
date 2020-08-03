using System.Threading.Tasks;
using Pegasus.Command.Server.Middleware.Wrappers;
using Pegasus.Command.Shared.Dto.Sample;

namespace Pegasus.Command.Server.Managers
{
    public interface ITodoManager
    {
        Task<ApiResponse> Get();
        Task<ApiResponse> Get(long id);
        Task<ApiResponse> Create(TodoDto todo);
        Task<ApiResponse> Update(TodoDto todo);
        Task<ApiResponse> Delete(long id);
    }
}