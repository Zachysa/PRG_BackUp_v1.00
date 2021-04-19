using Microsoft.AspNetCore.Mvc;
using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : Controller
    {
        public Authenticator Authenticator { get; set; } = new Authenticator();

        [HttpPost]
        public object Login(User login)
        {
            try
            {
                Token token = this.Authenticator.Authenticate(login.Username, login.Password);
                return new { result = token.Value };
            }
            catch
            {
                this.Response.StatusCode = 400;
                return new { result = "invalid" };
            }
        }

        [HttpDelete]
        public void Logout()
        {
            string token = this.Request.Headers["Authorization"].ToString().Split(' ').Last();
            this.Authenticator.Logout(token);
        }
    }
}
