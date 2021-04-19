using JWT.Algorithms;
using JWT.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PRG_BackUp_v1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRG_BackUp_v1._0.Controllers
{
    public class AuthAttribute : Attribute, IAuthorizationFilter
    {
        public Authenticator Authenticator { get; set; } = new Authenticator();

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string token = context.HttpContext.Request.Headers["Authorization"].ToString().Split(' ').Last();

            try
            {
                this.Authenticator.ValidateToken(token);
            }
            catch
            {
                context.Result = new JsonResult(new { message = "authentication failed" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
