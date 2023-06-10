using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QRCoder;
using soatveonline.Model;
using soatveonline.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace soatveonline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {

        private readonly DbContext _context;
        public TicketsController(DbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tickets>>> GetTickets()
        {
            if (_context.tickets == null)
            {
                return NotFound();
            }
            return await _context.tickets.ToListAsync();
        }
        [HttpGet("{id}")]
        public ActionResult<tickets> GetTicket(int id)
        {
            try
            {
                var ticket = _context.tickets.Include(x => x.TicketTypess).FirstOrDefault(x => x.TicketID == id);
                if (ticket == null)
                {
                    return NotFound();
                }
                var tickets = _context.ickets.AsNoTracking()
                    .Where(x => x.TicketTypeId == ticket.TicketTypeId && x.TicketID != id)
                    .OrderByDescending(x => x.CreatedDate)
                    .Take(5)
                    .ToList();
                return ticket;
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet("get_qrcode_ticket")]

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, tickets tickets)
        {
            if (id != tickets.TicketID)
            {
                return BadRequest();
            }

            _context.Entry(tickets).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TicketExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<tickets>> PostTicket(tickets tickets)
        {
            if (_context.tickets == null)
            {
                return Problem("Entity set 'DataContext.Tickets'  is null.");
            }
            _context.tickets.Add(tickets);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTicket", new { id = tickets.TicketID }, tickets);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            if (_context.tickets == null)
            {
                return NotFound();
            }
            var ticket = await _context.tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool TicketExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}

