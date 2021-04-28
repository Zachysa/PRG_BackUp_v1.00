using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.DatabaseRepository;
using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]

    public class BackUpController : ControllerBase
    {
        private BackUpRepository repository = new BackUpRepository();

        [HttpGet]
        public List<Backup> Get()
        {
            return this.repository.FindAll();
        }

        [HttpGet("idPcBackup")]
        public List<Backup> GetByConfig(int id)
        {
            return this.repository.FindByPcBackup(id);
        }

        [HttpGet("{id}")]
        public Backup Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public Backup New(Backup backup)
        {
            return this.repository.Add(backup);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            Backup backup = this.repository.FindById(id);
            this.repository.Remove(backup);
            return true;
        }

        [HttpPut("{id}")]
        public Backup Update(int id, Backup backup)
        {
            backup.Id = id;
            return this.repository.Update(backup);
        }
    }
}
