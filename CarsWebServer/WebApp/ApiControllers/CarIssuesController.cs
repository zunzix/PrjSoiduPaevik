using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.Domain;
using WebApp.Data;

namespace WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarIssuesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarIssuesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CarIssues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarIssue>>> GetCarIssues()
        {
            return await _context.CarIssues.ToListAsync();
        }

        // GET: api/CarIssues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarIssue>> GetCarIssue(Guid id)
        {
            var carIssue = await _context.CarIssues.FindAsync(id);

            if (carIssue == null)
            {
                return NotFound();
            }

            return carIssue;
        }

        // PUT: api/CarIssues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarIssue(Guid id, CarIssue carIssue)
        {
            if (id != carIssue.Id)
            {
                return BadRequest();
            }

            _context.Entry(carIssue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarIssueExists(id))
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

        // POST: api/CarIssues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarIssue>> PostCarIssue(CarIssue carIssue)
        {
            _context.CarIssues.Add(carIssue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarIssue", new { id = carIssue.Id }, carIssue);
        }

        // DELETE: api/CarIssues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarIssue(Guid id)
        {
            var carIssue = await _context.CarIssues.FindAsync(id);
            if (carIssue == null)
            {
                return NotFound();
            }

            _context.CarIssues.Remove(carIssue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarIssueExists(Guid id)
        {
            return _context.CarIssues.Any(e => e.Id == id);
        }
    }
}
