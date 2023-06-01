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
    public class ticketsController : ControllerBase
    {
        private readonly List<tickets> _tickets;

        public static List<tickets> Tickets = new List<tickets>();

        [HttpPost]
        public IActionResult Create(tickets tickets)
        {
            tickets.Id = _tickets.Count + 1;
            _tickets.Add(tickets);

            return CreatedAtRoute("GetticketsById", new { id = tickets.Id }, tickets);
        }

        [HttpGet("{id}", Name = "GetticketsById")]
        public IActionResult GetById(int id)
        {
            var tickets = _tickets.FirstOrDefault(p => p.Id == id);

            if (tickets == null)
            {
                return NotFound();
            }

            return Ok(tickets);
        }

    }
}
