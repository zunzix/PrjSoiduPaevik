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
public class CarIssuesController : Controller
{
    private readonly IAppUOW _uow;
    
    public CarIssuesController(IAppUOW uow)
    {
        _uow = uow;
    }

    // GET: CarIssues
    public async Task<IActionResult> Index()
    {
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);
        var res = await _uow.CarIssueRepository.AllCarIssuesAsync(userCars);
        
        return View(res);
    }

    // GET: CarIssues/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarIssueRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: CarIssues/Create
    public IActionResult Create()
    {
        var userGroups = _uow.GroupRepository.All(User.GetUserId());
        var userCars = _uow.CarRepository.AllCars(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View();
    }

    // POST: CarIssues/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CarIssue carIssue)
    {
        if (ModelState.IsValid)
        {
            carIssue.Id = Guid.NewGuid();
            _uow.CarIssueRepository.Add(carIssue);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carIssue.CarId);
        return View(carIssue);
    }

    // GET: CarIssues/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarIssueRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View(entity);
    }

    // POST: CarIssues/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, CarIssue carIssue)
    {

        if (id != carIssue.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _uow.CarIssueRepository.Update(carIssue);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        var userGroups = await _uow.GroupRepository.AllAsync(User.GetUserId());
        var userCars = await _uow.CarRepository.AllCarsAsync(userGroups);

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carIssue.CarId);
        return View(carIssue);
    }

    // GET: CarIssues/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.CarIssueRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // POST: CarIssues/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _uow.CarIssueRepository.RemoveAsync(id);
        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
}