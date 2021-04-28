using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.DatabaseRepository;
using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]

    public class BackUpConfigController : ControllerBase
    {
        private BackUpConfigRepositary repository = new BackUpConfigRepositary();

        [HttpGet]
        public List<BackUpConfig> Get()
        {
            return this.repository.WritteAll();
        }

        [HttpGet("{id}")]
        public BackUpConfig Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public BackUpConfig New(BackUpConfig backupconfig)
        {
            return this.repository.Add(backupconfig);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            BackUpConfig backupconfig = this.repository.FindById(id);
            this.repository.Remove(backupconfig);
            return true;
        }

        [HttpPut("{id}")]
        public BackUpConfig Update(int id, BackUpConfig backupconfig)
        {
            backupconfig.Id = id;
            return this.repository.Update(backupconfig);
        }
    }
}
