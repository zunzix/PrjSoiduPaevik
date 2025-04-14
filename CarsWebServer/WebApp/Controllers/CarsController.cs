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
public class CarsController : Controller
{
    //private readonly AppDbContext _context;
    private readonly CarRepository _carRepository;
    private readonly GroupRepository _groupRepository;

    public CarsController(AppDbContext context, CarRepository carRepository, GroupRepository groupRepository)
    {
        //_context = context;
        _carRepository = carRepository;
        _groupRepository = groupRepository;
    }

    // GET: Cars
    public async Task<IActionResult> Index()
    {
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var res = await _carRepository.AllCarsAsync(userGroups);
        
        return View(res);
    }

    // GET: Cars/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _carRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: Cars/Create
    public IActionResult Create()
    {
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name");
        return View();
    }

    // POST: Cars/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Car car)
    {
        if (ModelState.IsValid)
        {
            car.Id = Guid.NewGuid();
            _carRepository.Add(car);
            await _carRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name", car.GroupId);
        return View(car);
    }

    // GET: Cars/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _carRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name");
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

        if (ModelState.IsValid)
        {
            _carRepository.Update(car);
            await _carRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name", car.GroupId);
        return View(car);
    }

    // GET: Cars/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _carRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // POST: Cars/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _carRepository.RemoveAsync(id);
        await _carRepository.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}