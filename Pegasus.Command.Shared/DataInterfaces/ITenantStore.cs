using Pegasus.Command.Server.Models;
using Pegasus.Command.Shared.Dto.Tenant;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pegasus.Command.Shared.DataInterfaces
{
    public interface ITenantStore
    {
        List<TenantDto> GetAll();

        TenantDto GetById(long id);

        Task<Tenant> Create(TenantDto tenantDto);

        Task<Tenant> Update(TenantDto tenantDto);

        Task DeleteById(long id);
    }
}
