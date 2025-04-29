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
public class CarsController : Controller
{
    private readonly IAppUOW _uow;
    
    public CarsController(IAppUOW uow)
    {
        _uow = uow;
    }

    // GET: Cars
    public async Task<IActionResult> Index()
    {
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var res = await _uow.CarRepository.AllCarsAsync(userGroups);
        
        return View(res);
    }

    // GET: Cars/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: Cars/Create
    public IActionResult Create()
    {
        ViewData["GroupId"] = new SelectList(_uow.GroupRepository.AllAdmins(User.GetUserId()), "Id", "Name");
        return View();
    }

    // POST: Cars/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Car car)
    {
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), car.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }
        
        if (ModelState.IsValid)
        {
            car.Id = Guid.NewGuid();
            _uow.CarRepository.Add(car);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name", car.GroupId);
        return View(car);
    }

    // GET: Cars/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }
        
        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name");
        return View(entity);
    }

    // POST: Cars/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, Car car)
    {
        if (id != car.Id)
        {
            return NotFound();
        }
        
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), car.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }

        if (ModelState.IsValid)
        {
            _uow.CarRepository.Update(car);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name", car.GroupId);
        return View(car);
    }

    // GET: Cars/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }

        return View(entity);
    }

    // POST: Cars/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var entity = await _uow.CarRepository.FindAsync(id, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }
        
        await _uow.CarRepository.RemoveCarWithDependenciesAsync(entity);
        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}