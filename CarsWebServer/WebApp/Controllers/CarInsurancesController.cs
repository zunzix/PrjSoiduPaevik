using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using App.DAL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.DAL.EF.Repositories;
using App.DAL.DTO;
using Base.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
public class CarInsurancesController : Controller
{
    private readonly IAppUOW _uow;
    
    public CarInsurancesController(IAppUOW uow)
    {
        _uow = uow;
    }

    // GET: CarInsurances
    public async Task<IActionResult> Index()
    {
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
        var res = await _uow.CarInsuranceRepository.AllCarInsurancesAsync(userCars);
        
        return View(res);
    }

    // GET: CarInsurances/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarInsuranceRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: CarInsurances/Create
    public IActionResult Create()
    {
        var userGroups = _uow.GroupRepository.All(User.GetUserId());
        var userCars = _uow.CarRepository.AllCars(userGroups);
        
        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View();
    }

    // POST: CarInsurances/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CarInsurance carInsurance)
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
        
        if (ModelState.IsValid)
        {
            carInsurance.EndDate = DateTime.SpecifyKind(carInsurance.EndDate, DateTimeKind.Utc);
                
            carInsurance.Id = Guid.NewGuid();
            _uow.CarInsuranceRepository.Add(carInsurance);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
        
        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carInsurance.CarId);
        return View(carInsurance);
    }

    // GET: CarInsurances/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarInsuranceRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.Car!.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }
        
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View(entity);
    }

    // POST: CarInsurances/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, CarInsurance carInsurance)
    {

        if (id != carInsurance.Id)
        {
            return NotFound();
        }
        
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), carInsurance.Car!.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }

        if (ModelState.IsValid)
        {
            _uow.CarInsuranceRepository.Update(carInsurance);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carInsurance.CarId);
        return View(carInsurance);
    }

    // GET: CarInsurances/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarInsuranceRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.Car!.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }

        return View(entity);
    }

    // POST: CarInsurances/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var entity = await _uow.CarInsuranceRepository.FindAsync(id, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.Car!.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }
        
        await _uow.CarInsuranceRepository.RemoveAsync(id);
        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
}