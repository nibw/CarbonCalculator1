using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.IService;
using WebAPI.Models;
using WebAPI.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseholdController : ControllerBase
    {
        IHouseholdService _HouseholdService = null;

        public HouseholdController(IHouseholdService HouseholdService)
        {
            _HouseholdService = HouseholdService;
        }

        // GET: api/<HouseholdController>
        [HttpGet]
        public IEnumerable<Household> Get()
        {
            return _HouseholdService.GetList();
        }

        // GET api/<HouseholdController>/5
        [HttpGet("{id}")]
        public Household Get(int id)
        {
            return _HouseholdService.GetById(id);
        }

        // POST api/<HouseholdController>
        [HttpPost]
        public void AddOrEdit([FromForm] Household household)
        {
            if (household.HouseholdId == 0) _HouseholdService.save(household);
            else _HouseholdService.update(household);
        }

        //// PUT api/<HouseholdController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<HouseholdController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _HouseholdService.Delete(id);
        }
    }
}
