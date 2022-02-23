using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi2.Controllers.Otros
{
    [Route("api/[controller]")]
    [ApiController]
    public class FechaTiempo : ControllerBase
    {
        [HttpGet]
        public DateTime GetFechaTiempo()
        {
            return DateTime.Now;
        }
    }
}
