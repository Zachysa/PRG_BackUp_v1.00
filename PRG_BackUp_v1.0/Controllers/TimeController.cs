using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.DatabaseRepository;
using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]

    public class TimeController : ControllerBase
    {
        private TimeRepositary repository = new TimeRepositary();

        [HttpGet]
        public List<Time> Get()
        {
            return this.repository.WritteAll();
        }

        [HttpGet("idConfig")]
        public List<Time> GetByConfig(int id)
        {
            return this.repository.FindByConfig(id);
        }

        [HttpGet("{id}")]
        public Time Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public Time New(Time time)
        {
            return this.repository.Add(time);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            Time time = this.repository.FindById(id);
            this.repository.Remove(time);
            return true;
        }

        [HttpPut("{id}")]
        public Time Update(int id, Time time)
        {
            time.Id = id;
            return this.repository.Update(time);
        }
    }
}
