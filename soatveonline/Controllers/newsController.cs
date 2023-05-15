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
    public class newsController : ControllerBase
    {
        private readonly List<news> _news;

        public static List<news> locations = new List<news>();

        [HttpPost]
        public IActionResult Create(news news)
        {
            news.Id = _news.Count + 1;
            _news.Add(news);

            return CreatedAtRoute("GetnewsById", new { id = news.Id }, news);
        }

        [HttpGet("{id}", Name = "GetnewsById")]
        public IActionResult GetById(int id)
        {
            var news = _news.FirstOrDefault(p => p.Id == id);

            if (news == null)
            {
                return NotFound();
            }

            return Ok(news);
        }
    }
}
