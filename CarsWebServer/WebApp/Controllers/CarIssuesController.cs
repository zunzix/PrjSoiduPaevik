using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
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
    private readonly GroupRepository _groupRepository;
    private readonly CarRepository _carRepository;
    private readonly CarIssueRepository _carIssueRepository;

    public CarIssuesController(GroupRepository groupRepository, CarRepository carRepository, CarIssueRepository carIssueRepository)
    {
        _groupRepository = groupRepository;
        _carRepository = carRepository;
        _carIssueRepository = carIssueRepository;
    }

    // GET: CarIssues
    public async Task<IActionResult> Index()
    {
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);
        var res = await _carIssueRepository.AllCarIssuesAsync(userCars);
        
        return View(res);
    }

    // GET: CarIssues/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _carIssueRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: CarIssues/Create
    public IActionResult Create()
    {
        var userGroups = _groupRepository.All(User.GetUserId());
        var userCars = _carRepository.AllCars(userGroups);

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
            _carIssueRepository.Add(carIssue);
            await _carIssueRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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

        var entity = await _carIssueRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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
            _carIssueRepository.Update(carIssue);
            await _carIssueRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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

        var entity = await _carIssueRepository.FindAsync(id.Value, User.GetUserId());
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
        await _carIssueRepository.RemoveAsync(id);
        await _carIssueRepository.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
}