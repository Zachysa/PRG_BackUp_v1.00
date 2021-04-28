using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.DatabaseRepository;
using PRG_BackUp_v1._0.Models;
using System.Collections.Generic;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Auth]

    public class StorageController : ControllerBase
    {
        private StorageRepositary repository = new StorageRepositary();

        [HttpGet]
        public List<Storage> Get()
        {
            return this.repository.WritteAll();
        }

        [HttpGet("idConfig")]
        public List<Storage> GetByConfig(int id)
        {
            return this.repository.FindByConfig(id);
        }

        [HttpGet("{id}")]
        public Storage Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public Storage New(Storage storage)
        {
            return this.repository.Add(storage);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            Storage storage = this.repository.FindById(id);
            this.repository.Remove(storage);
            return true;

        }

        [HttpPut("{id}")]
        public Storage Update(int id, Storage storage)
        {
            storage.Id = id;
            return this.repository.Update(storage);
        }
    }
}
