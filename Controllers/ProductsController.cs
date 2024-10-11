using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetBooks() {
            return "Products list";
        }

        [HttpGet("{id}")]
        public string GetBookById(int id) {
            return "a product";
        }

    }
}