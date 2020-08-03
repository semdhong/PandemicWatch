using Pegasus.Models.Maintenance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pegasus.Services.Maintenance
{
    public interface IIsolationService
    {
        IEnumerable<IsolationCenterModel> GetIsolationCenters();
        IsolationCenterModel GetIsolationCenter(int id);
        void CreateIsolationCenter(IsolationCenterModel model);
        void UpdateIsolationCenter(IsolationCenterModel model);
    }
}
