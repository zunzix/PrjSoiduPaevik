using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.Domain;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
public class CarInsurancesController : Controller
{
    private readonly AppDbContext _context;

    public CarInsurancesController(AppDbContext context)
    {
        _context = context;
    }

    // GET: CarInsurances
    public async Task<IActionResult> Index()
    {
        //Ask only data for current user
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        var res = await _context
            .CarInsurances
            .Include(c => c.Car)
            .ThenInclude(car => car!.Group)
            .Where(cl => cl.Car!.Group!.GroupMembers!
                .Any(gm => gm.UserId == userId))
            .ToListAsync();
        
        return View(res);
    }

    // GET: CarInsurances/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var carInsurance = await _context.CarInsurances
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (carInsurance == null)
        {
            return NotFound();
        }

        return View(carInsurance);
    }

    // GET: CarInsurances/Create
    public IActionResult Create()
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        // Get cars that belong to groups where the user is a member
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View();
    }

    // POST: CarInsurances/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CarId,Name,EndDate,Id")] CarInsurance carInsurance)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (ModelState.IsValid)
        {
            carInsurance.EndDate = DateTime.SpecifyKind(carInsurance.EndDate, DateTimeKind.Utc);
                
            carInsurance.Id = Guid.NewGuid();
            _context.Add(carInsurance);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // If model is invalid, repopulate the filtered car list
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

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

        var carInsurance = await _context.CarInsurances.FindAsync(id);
        if (carInsurance == null)
        {
            return NotFound();
        }
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        // Get cars that belong to groups where the user is a member
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View(carInsurance);
    }

    // POST: CarInsurances/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("CarId,Name,EndDate,Id")] CarInsurance carInsurance)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (id != carInsurance.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(carInsurance);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarInsuranceExists(carInsurance.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        // If model is invalid, repopulate the filtered car list
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

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

        var carInsurance = await _context.CarInsurances
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (carInsurance == null)
        {
            return NotFound();
        }

        return View(carInsurance);
    }

    // POST: CarInsurances/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var carInsurance = await _context.CarInsurances.FindAsync(id);
        if (carInsurance != null)
        {
            _context.CarInsurances.Remove(carInsurance);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CarInsuranceExists(Guid id)
    {
        return _context.CarInsurances.Any(e => e.Id == id);
    }
}