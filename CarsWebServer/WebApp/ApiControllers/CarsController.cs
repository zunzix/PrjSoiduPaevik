using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DAL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.DAL.DTO;
using Base.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

// todo : add user specific Find


namespace WebApp.ApiControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CarsController : ControllerBase
    {
        private readonly IAppUOW _uow;

        public CarsController(IAppUOW uow)
        {
            _uow = uow;
        }

        // GET: api/Cars
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCars()
        {
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var cars = await _uow.CarRepository.AllCarsAsync(userGroups);
    
            return Ok(cars.Select(c => new 
            {
                c.Id,
                c.GroupId,
                c.Name,
                c.Mileage,
                c.AvgFuelCons,
                c.IsAvailable,
                c.IsArchived,
                c.IsCritical
            }).ToList());
        }
        
        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Car>>> GetGroupCars(Guid id)
        {
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var cars = await _uow.CarRepository.AllCarsAsync(userGroups);
            var groupCars = await _uow.CarRepository.AllGroupCarsAsync(cars, id);
    
            return Ok(groupCars.Select(c => new 
            {
                c.Id,
                c.GroupId,
                c.Name,
                c.RegistrationPlate,
                c.Mileage,
                c.AvgFuelCons,
                c.IsAvailable,
                c.IsArchived,
                c.IsCritical
            }).ToList());
        }

        // GET: api/Cars/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(Guid id)
        {
            var car = await _uow.CarRepository.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // PUT: api/Cars/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(Guid id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }
            
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), car.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _uow.CarRepository.Update(car);
            await _uow.SaveChangesAsync();
            
            return NoContent();
        }

        // POST: api/Cars
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), car.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }
            
            _uow.CarRepository.Add(car);
            await _uow.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.Id }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(Guid id)
        {
            var car = await _uow.CarRepository.FindAsync(id);
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

            _uow.CarRepository.Remove(car);
            await _uow.SaveChangesAsync();

            return NoContent();
        }

    }
}
