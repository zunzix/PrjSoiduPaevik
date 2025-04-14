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
public class CarLogsController : Controller
{
    //private readonly AppDbContext _context;
    private readonly CarLogRepository _carLogRepository;
    private readonly CarRepository _carRepository;
    private readonly GroupRepository _groupRepository;

    public CarLogsController(AppDbContext context, CarLogRepository carLogRepository, CarRepository carRepository, GroupRepository groupRepository)
    {
        //_context = context;
        _carLogRepository = carLogRepository;
        _carRepository = carRepository;
        _groupRepository = groupRepository;
    }

    // GET: CarLogs
    public async Task<IActionResult> Index()
    {
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);
        var res = await _carLogRepository.AllCarLogsAsync(userCars);
        
        return View(res);
    }

    // GET: CarLogs/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _carLogRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: CarLogs/Create
    public IActionResult Create()
    {
        var userGroups = _groupRepository.All(User.GetUserId());
        var userCars = _carRepository.AllCars(userGroups);

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
            _carLogRepository.Add(carLog);
            await _carLogRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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

        var entity = await _carLogRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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
            _carLogRepository.Update(carLog);
            await _carLogRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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

        var entity = await _carLogRepository.FindAsync(id.Value, User.GetUserId());
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
        await _carLogRepository.RemoveAsync(id);
        await _carLogRepository.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}