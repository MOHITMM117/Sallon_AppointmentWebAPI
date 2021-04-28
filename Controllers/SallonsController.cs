using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sallon_Appointment_API.Data;
using Sallon_Appointment_API.Models;

namespace Sallon_Appointment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SallonsController : ControllerBase
    {
        private readonly Sallon_Appointment_APIContext _context;

        public SallonsController(Sallon_Appointment_APIContext context)
        {
            _context = context;
        }

        // GET: api/Sallons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sallon>>> GetSallon()
        {
            return await _context.Sallon.ToListAsync();
        }

        // GET: api/Sallons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sallon>> GetSallon(int id)
        {
            var sallon = await _context.Sallon.FindAsync(id);

            if (sallon == null)
            {
                return NotFound();
            }

            return sallon;
        }

        // PUT: api/Sallons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSallon(int id, Sallon sallon)
        {
            if (id != sallon.Sallon_ID)
            {
                return BadRequest();
            }

            _context.Entry(sallon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SallonExists(id))
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

        // POST: api/Sallons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sallon>> PostSallon(Sallon sallon)
        {
            _context.Sallon.Add(sallon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSallon", new { id = sallon.Sallon_ID }, sallon);
        }

        // DELETE: api/Sallons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSallon(int id)
        {
            var sallon = await _context.Sallon.FindAsync(id);
            if (sallon == null)
            {
                return NotFound();
            }

            _context.Sallon.Remove(sallon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SallonExists(int id)
        {
            return _context.Sallon.Any(e => e.Sallon_ID == id);
        }
    }
}
