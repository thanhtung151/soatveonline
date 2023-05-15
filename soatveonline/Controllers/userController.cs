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
    public class userController : ControllerBase
    {
        private readonly List<user> _user;

        public static List<user> locations = new List<user>();

        [HttpPost]
        public IActionResult Create(user user)
        {
            user.Id = _user.Count + 1;
            _user.Add(user);

            return CreatedAtRoute("GetticketsById", new { id = user.Id }, user);
        }

        [HttpGet("{id}", Name = "GetticketsById")]
        public IActionResult GetById(int id)
        {
            var user = _user.FirstOrDefault(p => p.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
