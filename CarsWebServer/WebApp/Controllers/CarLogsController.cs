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
using App.Domain;
using Base.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
public class CarLogsController : Controller
{
    
    private readonly IAppUOW _uow;
    
    public CarLogsController(IAppUOW uow)
    {
        _uow = uow;
    }

    // GET: CarLogs
    public async Task<IActionResult> Index()
    {
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
        var res = await _uow.CarLogRepository.AllCarLogsAsync(userCars);
        
        return View(res);
    }

    // GET: CarLogs/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarLogRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: CarLogs/Create
    public IActionResult Create()
    {
        var userGroups = _uow.GroupRepository.All(User.GetUserId());
        var userCars = _uow.CarRepository.AllCars(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View();
    }

    // POST: CarLogs/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CarLog carLog)
    {
        
        carLog.UserId = User.GetUserId();
        
        if (ModelState.IsValid)
        {
            carLog.EndDate = DateTime.SpecifyKind(carLog.EndDate, DateTimeKind.Utc);
            carLog.StartDate = DateTime.SpecifyKind(carLog.StartDate, DateTimeKind.Utc);
                
            carLog.Id = Guid.NewGuid();
            _uow.CarLogRepository.Add(carLog);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carLog.CarId);
        return View(carLog);
    }

    // GET: CarLogs/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarLogRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View(entity);
    }

    // POST: CarLogs/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, CarLog carLog)
    {
        
        if (id != carLog.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _uow.CarLogRepository.Update(carLog);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carLog.CarId);
        return View(carLog);
    }

    // GET: CarLogs/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarLogRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // POST: CarLogs/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _uow.CarLogRepository.RemoveAsync(id);
        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}