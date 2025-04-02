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
    public class CarInsurancesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarInsurancesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CarInsurances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarInsurance>>> GetCarInsurances()
        {
            return await _context.CarInsurances.ToListAsync();
        }

        // GET: api/CarInsurances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarInsurance>> GetCarInsurance(Guid id)
        {
            var carInsurance = await _context.CarInsurances.FindAsync(id);

            if (carInsurance == null)
            {
                return NotFound();
            }

            return carInsurance;
        }

        // PUT: api/CarInsurances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarInsurance(Guid id, CarInsurance carInsurance)
        {
            if (id != carInsurance.Id)
            {
                return BadRequest();
            }

            _context.Entry(carInsurance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarInsuranceExists(id))
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

        // POST: api/CarInsurances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarInsurance>> PostCarInsurance(CarInsurance carInsurance)
        {
            _context.CarInsurances.Add(carInsurance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarInsurance", new { id = carInsurance.Id }, carInsurance);
        }

        // DELETE: api/CarInsurances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarInsurance(Guid id)
        {
            var carInsurance = await _context.CarInsurances.FindAsync(id);
            if (carInsurance == null)
            {
                return NotFound();
            }

            _context.CarInsurances.Remove(carInsurance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarInsuranceExists(Guid id)
        {
            return _context.CarInsurances.Any(e => e.Id == id);
        }
    }
}
