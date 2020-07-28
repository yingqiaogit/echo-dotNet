using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EchoPeer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PeersController : ControllerBase
    {
        private string hello = "Hello World";

        [HttpGet]
        public string Get()
        {
            return hello;
        }

        [HttpGet("{name}")]
        public string Get(string name)
        {
            return hello + " from " + name;
        }
    }
}
