using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]

    public class PcController : ControllerBase
    {
        private PcRepositary repositary = new PcRepositary();

        [HttpGet]
        public List<Pc> WritteAll()
        {

            return this.repositary.WritteAll();
        }

        [HttpGet("{id}")]
        public Pc FindById(int id)
        {
            return this.repositary.FindById(id);
        }

        [HttpPost]
        public Pc New(Pc pc)
        {
            return this.repositary.Add(pc);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            Pc pc = this.repositary.FindById(id);
            this.repositary.Remove(pc);
            return true;
        }

        [HttpPut("{id}")]
        public Pc Update(int id, Pc pc)
        {
            pc.Id = id;
            return this.repositary.Update(pc);
        }
    }
}
