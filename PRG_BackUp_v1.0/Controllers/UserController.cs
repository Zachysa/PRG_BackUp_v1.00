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
  
   
    public class UserController : ControllerBase
    {
        private UserRepositary repository = new UserRepositary();

        [HttpGet]
        public List<User> Get()
        {
            return this.repository.WritteAll();
        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return this.repository.FindById(id);
        }

        [HttpPost]
        public User New(User user)
        {
            return this.repository.Add(user);
        }

        [HttpDelete("{id}")]
        public bool Remove(int id)
        {
            User user = this.repository.FindById(id);
            this.repository.Remove(user);
            return true;
        }

        [HttpPut("{id}")]
        public User Update(int id, User user)
        {
            user.Id = id;
            return this.repository.Update(user);
        }
    }
}
