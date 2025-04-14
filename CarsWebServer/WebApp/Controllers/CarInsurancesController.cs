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
public class CarInsurancesController : Controller
{
    private readonly GroupRepository _groupRepository;
    private readonly CarRepository _carRepository;
    private readonly CarInsuranceRepository _carInsuranceRepository;

    public CarInsurancesController(GroupRepository groupRepository, CarRepository carRepository, CarInsuranceRepository carInsuranceRepository)
    {
        _groupRepository = groupRepository;
        _carRepository = carRepository;
        _carInsuranceRepository = carInsuranceRepository;
    }

    // GET: CarInsurances
    public async Task<IActionResult> Index()
    {
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);
        var res = await _carInsuranceRepository.AllCarInsurancesAsync(userCars);
        
        return View(res);
    }

    // GET: CarInsurances/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _carInsuranceRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: CarInsurances/Create
    public IActionResult Create()
    {
        var userGroups = _groupRepository.All(User.GetUserId());
        var userCars = _carRepository.AllCars(userGroups);
        
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
        if (ModelState.IsValid)
        {
            carInsurance.EndDate = DateTime.SpecifyKind(carInsurance.EndDate, DateTimeKind.Utc);
                
            carInsurance.Id = Guid.NewGuid();
            _carInsuranceRepository.Add(carInsurance);
            await _carInsuranceRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);
        
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

        var entity = await _carInsuranceRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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

        if (ModelState.IsValid)
        {
            _carInsuranceRepository.Update(carInsurance);
            await _carInsuranceRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        var userGroups = await _groupRepository.AllAsync(User.GetUserId());
        var userCars = await _carRepository.AllCarsAsync(userGroups);

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

        var entity = await _carInsuranceRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // POST: CarInsurances/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _carInsuranceRepository.RemoveAsync(id);
        await _carInsuranceRepository.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
    
}