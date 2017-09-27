using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ElementAPI.Data;

namespace ElementAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Planets")]
    public class PlanetsController : Controller
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(PlanetDataStore.Current.Planets);
        }
    }
}