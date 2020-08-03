using Pegasus.Data;
using Pegasus.Models.Maintenance;
using Pegasus.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pegasus.Services.Maintenance
{

    public class IsolationCenterService : IIsolationService
    {
        private readonly IRepository<IsolationCenters> _repoIso;
        public IsolationCenterService(IRepository<IsolationCenters> repoIso)
        {
            _repoIso = repoIso;
        }
        public void CreateIsolationCenter(IsolationCenterModel model)
        {
            _repoIso.AddAsync(new IsolationCenters
            {
                CenterName = model.Centername,
                Address = model.Address,
                ContactNo = model.ContactNo
            });
        }

        public IsolationCenterModel GetIsolationCenter(int id)
        {
            return _repoIso.GetAll().Select(x => new IsolationCenterModel
            {
                Id = x.Id,
                Address = x.Address,
                Centername = x.CenterName,
                ContactNo = x.ContactNo
            }).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<IsolationCenterModel> GetIsolationCenters()
        {
            return _repoIso.GetAll().Select(x => new IsolationCenterModel
            {
                Id = x.Id,
                Address = x.Address,
                Centername = x.CenterName,
                ContactNo = x.ContactNo
            });

        }

        public void UpdateIsolationCenter(IsolationCenterModel model)
        {
            _repoIso.UpdateAsync(new IsolationCenters
            {
                 Id =model.Id,
                CenterName = model.Centername,
                Address = model.Address,
                ContactNo = model.ContactNo
            });
        }
    }
}
