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
using Base.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis;

// todo : add user specific Find
// todo : remove _context

namespace WebApp.ApiControllers
{
    [Route("api/[controller]/[action]")]
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
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
            var carLogs = await _uow.CarLogRepository.AllCarLogsAsync(userCars);
            return Ok(carLogs.Select(c => new 
            {
                c.Id,
                c.UserId,
                c.CarId,
                c.StartDate,
                c.EndDate,
                c.StartPoint,
                c.EndPoint,
                c.Distance,
                c.Comment
            }).ToList());
        }
        
        // GET: api/CarLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarLog>> GetCarCarLogs(Guid id)
        {
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
            var carLogs = await _uow.CarLogRepository.AllCarLogsAsync(userCars);
            var carCarLogs = await _uow.CarLogRepository.AllCarCarLogsAsync(carLogs, id);
            
            return Ok(carCarLogs.Select(c => new 
            {
                c.Id,
                c.UserId,
                c.CarId,
                c.StartDate,
                c.EndDate,
                c.StartPoint,
                c.EndPoint,
                c.Distance,
                c.Comment
            }).ToList());
        }

        // GET: api/CarLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarLog>> GetCarLog(Guid id)
        {
            var carLog = await _uow.CarLogRepository.FindAsync(id);

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
            
            var car = await _uow.CarRepository.FindAsync(carLog.CarId);
            if (car == null)
            {
                return NotFound();
            }
        
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), car.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _context.Entry(carLog).State = EntityState.Modified;
            await _uow.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/CarLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarLog>> PostCarLog(CarLog carLog)
        {
            var car = await _uow.CarRepository.FindAsync(carLog.CarId);
            if (car == null)
            {
                return NotFound();
            }
        
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserInGroup(User.GetUserId(), car.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }
            
            _uow.CarLogRepository.Add(carLog);
            await _uow.SaveChangesAsync();

            return CreatedAtAction("GetCarLog", new { id = carLog.Id }, carLog);
        }

        // DELETE: api/CarLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarLog(Guid id)
        {
            var carLog = await _uow.CarLogRepository.FindAsync(id);
            if (carLog == null)
            {
                return NotFound();
            }
            
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), carLog.Car!.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _uow.CarLogRepository.Remove(carLog);
            await _uow.SaveChangesAsync();

            return NoContent();
        }

    }
}
