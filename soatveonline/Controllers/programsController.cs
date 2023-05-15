using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using soatveonline.Model;

namespace soatveonline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class programsController : ControllerBase
    {
        private readonly List<programs> _programs;

        public static List<programs> locations = new List<programs>();

        [HttpPost]
        public IActionResult Create(programs programs)
        {
            programs.Id = _programs.Count + 1;
            _programs.Add(programs);

            return CreatedAtRoute("GetprogramsById", new { id = programs.Id }, programs);
        }

        [HttpGet("{id}", Name = "GetprogramsById")]
        public IActionResult GetById(int id)
        {
            var programs = _programs.FirstOrDefault(p => p.Id == id);

            if (programs == null)
            {
                return NotFound();
            }

            return Ok(programs);
        }
    }
}
