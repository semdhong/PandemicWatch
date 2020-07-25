using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Profiles;
using Pegasus.Services.Maintenance;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IUserAgentService _agentService;
        public AgentController(IUserAgentService agentService)
        {
            _agentService = agentService;
        }
        // GET: api/<AgentController>
        [HttpGet]
        public IEnumerable<AgentModel> Get()
        {
            return _agentService.GetAgents();
        }

        // GET api/<AgentController>/5
        [HttpGet("{id}")]
        public AgentModel Get(int id)
        {
            return _agentService.GetAgent(id);
        }

        // POST api/<AgentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgentController>/5
       
        public void Put(AgentModel model)
        {
            if (model.Id == 0)
            {
                _agentService.CreateAgent(model);
            }
            else
            {
                _agentService.UpdateAgent(model);
            }
        }

        // DELETE api/<AgentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
