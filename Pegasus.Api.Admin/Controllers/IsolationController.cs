using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Maintenance;
using Pegasus.Models.Profiles;
using Pegasus.Services.Maintenance;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsolationController : ControllerBase
    {
        private readonly IIsolationService _isolationService;
        public IsolationController(IIsolationService isolationService)
        {
            _isolationService = isolationService;
        }
        // GET: api/<AgentController>
        [HttpGet]
        public IEnumerable<IsolationCenterModel> Get()
        {
            return _isolationService.GetIsolationCenters();
        }

        // GET api/<AgentController>/5
        [HttpGet("{id}")]
        public IsolationCenterModel Get(int id)
        {
            return _isolationService.GetIsolationCenter(id);
        }

        // POST api/<AgentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgentController>/5

        public void Put(IsolationCenterModel model)
        {
            if (model.Id == 0)
            {
                _isolationService.CreateIsolationCenter(model);
            }
            else
            {
                _isolationService.UpdateIsolationCenter(model);
            }
        }

        // DELETE api/<AgentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
