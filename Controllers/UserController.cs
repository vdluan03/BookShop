using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController
    {
        [HttpGet]
        public string GetUsers() {
            return "Users list";
        }
    }
}