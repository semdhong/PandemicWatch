﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pegasus.Models.Profiles;
using Pegasus.Services.Profile;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pegasus.Api.Agent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonProfileService _personService;
        public PersonController(IPersonProfileService personService)
        {
            _personService = personService;
        }
        // GET: api/<BarangayController>
        [HttpGet]
        public IEnumerable<PersonProfilesModel> GetPersonList()
        {
            return _personService.GetPersonProfiles();
        }
       

        // GET api/<BarangayController>/5
        [HttpGet("{id}")]
        public ActionResult<PersonProfilesModel> Get(int id)
        {
          var data = _personService.GetPersonProfile(id);
            return data;
        }


        // POST api/<BarangayController>
        [HttpPost]
        public void Post(PersonProfilesModel model)
        {
            _personService.CreatePersonProfile(model);
        }

        // PUT api/<BarangayController>/5
        [HttpPut]
        public void Put(PersonProfilesModel model)
        {
            if (model.Id == 0)
            {
                if(model.PrincipalPersonId==null || model.PrincipalPersonId==0)
                         model.PersonStatus = "P";

                _personService.CreatePersonProfile(model);
            }
            else
                _personService.UpdatePersonProfile(model);
        }

        // DELETE api/<BarangayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
