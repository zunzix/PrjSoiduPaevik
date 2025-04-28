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



namespace WebApp.ApiControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CarInsurancesController : ControllerBase
    {
        private readonly IAppUOW _uow;

        public CarInsurancesController(IAppUOW uow)
        {
            _uow = uow;
        }

        // GET: api/CarInsurances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarInsurance>>> GetCarInsurances()
        {
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
            var carInsurances = await _uow.CarInsuranceRepository.AllCarInsurancesAsync(userCars);
            return Ok(carInsurances.Select(c => new 
            {
                c.Id,
                c.CarId,
                c.Name,
                c.EndDate
            }).ToList());
        }
        
        // GET: api/CarInsurances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarInsurance>> GetCarCarInsurances(Guid id)
        {
            var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
            var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
            var carInsurances = await _uow.CarInsuranceRepository.AllCarInsurancesAsync(userCars);
            var carCarInsurances = await _uow.CarInsuranceRepository.AllCarCarInsurancesAsync(carInsurances, id);
            
            return Ok(carCarInsurances.Select(c => new 
            {
                c.Id,
                c.CarId,
                c.Name,
                c.EndDate
            }).ToList());
        }

        // GET: api/CarInsurances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarInsurance>> GetCarInsurance(Guid id)
        {
            var carInsurance = await _uow.CarInsuranceRepository.FindAsync(id, User.GetUserId());

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
            
            var car = await _uow.CarRepository.FindAsync(carInsurance.CarId);
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
            
            _uow.CarInsuranceRepository.Update(carInsurance);
            await _uow.SaveChangesAsync();


            return NoContent();
        }

        // POST: api/CarInsurances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarInsurance>> PostCarInsurance(CarInsurance carInsurance)
        {
            var car = await _uow.CarRepository.FindAsync(carInsurance.CarId);
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
            
            _uow.CarInsuranceRepository.Add(carInsurance);
            await _uow.SaveChangesAsync();

            return CreatedAtAction("GetCarInsurance", new { id = carInsurance.Id }, carInsurance);
        }

        // DELETE: api/CarInsurances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarInsurance(Guid id)
        {
            var carInsurance = await _uow.CarInsuranceRepository.FindAsync(id);
            if (carInsurance == null)
            {
                return NotFound();
            }
        
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserInGroup(User.GetUserId(), carInsurance.Car!.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _uow.CarInsuranceRepository.Remove(carInsurance);
            await _uow.SaveChangesAsync();

            return NoContent();
        }

    }
}
