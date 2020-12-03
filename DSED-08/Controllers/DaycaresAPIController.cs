using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DSED_06_AdoptAPet.Data;
using DSED_06_AdoptAPet.Models;

namespace DSED_06_AdoptAPet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaycaresAPIController : ControllerBase
    {
        private readonly UserDbContext _context;

        public DaycaresAPIController(UserDbContext context)
        {
            _context = context;
        }

        // GET: api/DaycaresAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Daycare>>> GetDaycare()
        {
            return await _context.Daycare.ToListAsync();
        }

        // GET: api/DaycaresAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Daycare>> GetDaycare(int id)
        {
            var daycare = await _context.Daycare.FindAsync(id);

            if (daycare == null)
            {
                return NotFound();
            }

            return daycare;
        }

        // PUT: api/DaycaresAPI/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDaycare(int id, Daycare daycare)
        {
            if (id != daycare.ID)
            {
                return BadRequest();
            }

            _context.Entry(daycare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DaycareExists(id))
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

        // POST: api/DaycaresAPI
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Daycare>> PostDaycare(Daycare daycare)
        {
            _context.Daycare.Add(daycare);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDaycare", new { id = daycare.ID }, daycare);
        }

        // DELETE: api/DaycaresAPI/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Daycare>> DeleteDaycare(int id)
        {
            var daycare = await _context.Daycare.FindAsync(id);
            if (daycare == null)
            {
                return NotFound();
            }

            _context.Daycare.Remove(daycare);
            await _context.SaveChangesAsync();

            return daycare;
        }

        private bool DaycareExists(int id)
        {
            return _context.Daycare.Any(e => e.ID == id);
        }
    }
}
