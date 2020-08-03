using System.Threading.Tasks;

namespace Pegasus.Command.Shared
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}