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

// todo : add user specific Find
// todo : remove _context

namespace WebApp.ApiControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CarIssuesController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAppUOW _uow;

        public CarIssuesController(AppDbContext context, IAppUOW uow)
        {
            _context = context;
            _uow = uow;
        }

        // GET: api/CarIssues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarIssue>>> GetCarIssues()
        {
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
            var carIssues = await _uow.CarIssueRepository.AllCarIssuesAsync(userCars);
            return Ok(carIssues.Select(c => new 
            {
                c.Id,
                c.CarId,
                c.Issue,
                c.IsCritical,
                c.IsResolved
            }).ToList());
        }

        // GET: api/CarIssues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarIssue>> GetCarIssue(Guid id)
        {
            var carIssue = await _uow.CarIssueRepository.FindAsync(id);

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
            
            var car = await _uow.CarRepository.FindAsync(carIssue.CarId);
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

            _context.Entry(carIssue).State = EntityState.Modified;
            
            await _uow.SaveChangesAsync();


            return NoContent();
        }

        // POST: api/CarIssues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarIssue>> PostCarIssue(CarIssue carIssue)
        {
            var car = await _uow.CarRepository.FindAsync(carIssue.CarId);
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
            
            _uow.CarIssueRepository.Add(carIssue);
            await _uow.SaveChangesAsync();

            return CreatedAtAction("GetCarIssue", new { id = carIssue.Id }, carIssue);
        }

        // DELETE: api/CarIssues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarIssue(Guid id)
        {
            var carIssue = await _uow.CarIssueRepository.FindAsync(id);
            if (carIssue == null)
            {
                return NotFound();
            }
            
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), carIssue.Car!.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _uow.CarIssueRepository.Remove(carIssue);
            await _uow.SaveChangesAsync();

            return NoContent();
        }

    }
}
