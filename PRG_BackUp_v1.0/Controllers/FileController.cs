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
   
    public class FileController : ControllerBase
    {
        private FileRepository repository = new FileRepository();

        [HttpGet]
        public List<File> Get()
        {
            return this.repository.FindAll();
        }

        [HttpGet("idConfig")]
        public List<File> GetByConfig(int id)
        {
            return this.repository.FindByConfig(id);
        }

        [HttpGet("{id}")]
        public File Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public File New(File file)
        {
            return this.repository.Add(file);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            File file = this.repository.FindById(id);
            this.repository.Remove(file);
            return true;
        }

        [HttpPut("{id}")]
        public File Update(int id, File file)
        {
            file.Id = id;
            return this.repository.Update(file);
        }
    }
}
