using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Profiles;
using Pegasus.Services.Profile;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonHistoryController : ControllerBase
    {
        private IPersonProfileService _personService;
        // GET: api/<PersonHistoryController>
        //[HttpGet]
        //public IEnumerable<PersonHistoryModel> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public PersonHistoryController(IPersonProfileService personService)
        {
            _personService = personService;
        }
        // GET api/<PersonHistoryController>/5
        [HttpGet("{id}")]
        public IEnumerable<PersonHistoryModel> Get(int id)
        {
            return _personService.GetPersonHistoryList(id);
        }

        // POST api/<PersonHistoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonHistoryController>/5
        [HttpPut]
        public void Put(PersonHistoryModel model)
        {
            if (model.Id == 0)
            {
                _personService.CreatePersonHistory(model);
            }
            else
            {
                _personService.UpdatePersonHistory(model);
            }
        }

        // DELETE api/<PersonHistoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
