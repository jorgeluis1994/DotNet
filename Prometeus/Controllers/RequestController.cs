using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Prometeus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        [HttpPost("user")]
        public async Task<IActionResult> CrearUser([FromBody] dynamic data){
            System.Console.WriteLine("LLego");
            var datos=data;
            { return Ok(datos);}

        }
    }
}