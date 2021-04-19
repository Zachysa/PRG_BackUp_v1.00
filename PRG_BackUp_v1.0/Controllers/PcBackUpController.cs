using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.DatabaseRepository;
using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PcBackUpController : ControllerBase
    {
        private PcBackUpRepository repository = new PcBackUpRepository();

        [HttpGet]
        public List<PcBackUp> Get()
        {
            return this.repository.WritteAll();
        }

        [HttpGet("idPc")]
        public List<PcBackUp> GetByPc(int id)
        {
            return this.repository.FindByPc(id);
        }

        [HttpGet("{id}")]
        public PcBackUp Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public PcBackUp New(PcBackUp pcbackup)
        {
            return this.repository.Add(pcbackup);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            PcBackUp pcbackup = this.repository.FindById(id);
            this.repository.Remove(pcbackup);
            return true;
        }

        [HttpPut("{id}")]
        public PcBackUp Update(int id, PcBackUp pcbackup)
        {
            pcbackup.Id = id;
            return this.repository.Update(pcbackup);
        }
    }
}
