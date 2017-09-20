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
    [Route("api/elements")]
    public class ElementsController : Controller
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(ElementDataStore.Current.Elements);
        }

        [HttpGet("{atomicNumber:int}")]
        public IActionResult Get(int atomicNumber)
        {
            //find element
            var element = ElementDataStore.Current.Elements
                            .FirstOrDefault(e => e.AtomicNumber == atomicNumber);
            if (element == null)
            {
                return NotFound();
            }
            return Ok(element);
        }

        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            //find element
            var elementByName = ElementDataStore.Current.Elements
                            .FirstOrDefault(e => e.Name == name);
            //if (element == null)
            //{
            //    return NotFound();
            //}
            return Ok(elementByName);
        }

    }
}