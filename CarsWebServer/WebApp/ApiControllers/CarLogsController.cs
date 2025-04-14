using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DAL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CarLogsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAppUOW _uow;

        public CarLogsController(AppDbContext context, IAppUOW uow)
        {
            _context = context;
            _uow = uow;
        }

        // GET: api/CarLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarLog>>> GetCarLogs()
        {
            return await _context.CarLogs.ToListAsync();
        }

        // GET: api/CarLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarLog>> GetCarLog(Guid id)
        {
            var carLog = await _context.CarLogs.FindAsync(id);

            if (carLog == null)
            {
                return NotFound();
            }

            return carLog;
        }

        // PUT: api/CarLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarLog(Guid id, CarLog carLog)
        {
            if (id != carLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(carLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarLogExists(id))
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

        // POST: api/CarLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarLog>> PostCarLog(CarLog carLog)
        {
            _context.CarLogs.Add(carLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarLog", new { id = carLog.Id }, carLog);
        }

        // DELETE: api/CarLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarLog(Guid id)
        {
            var carLog = await _context.CarLogs.FindAsync(id);
            if (carLog == null)
            {
                return NotFound();
            }

            _context.CarLogs.Remove(carLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarLogExists(Guid id)
        {
            return _context.CarLogs.Any(e => e.Id == id);
        }
    }
}
