using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using soatveonline.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace soatveonline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class locationController : ControllerBase
    {
        public static List<location> locations = new List<location>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(locations);
        }
        [HttpPost]
        public IActionResult Create(location location)
        {
            var location1 = new location
            {
                name = location.name,
                sumary = location.sumary,
                images = location.images,
            };
            return Ok(new
            {
                Success = true,
                Data = location
            });

        }
    }
}
