using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTPlantsForCD.Managers;
using RESTPlantsForCD.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RESTPlantsForCD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        private readonly PlantsManager _manager = new PlantsManager();

        // GET: api/<PlantsController>
        [HttpGet]
        public IEnumerable<Plant> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<PlantsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlantsController>
        [HttpPost]
        public Plant Post([FromBody] Plant plant)
        {
            return _manager.Add(plant);
        }

        // PUT api/<PlantsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlantsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
